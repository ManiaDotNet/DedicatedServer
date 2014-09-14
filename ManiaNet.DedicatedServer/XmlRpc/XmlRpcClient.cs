using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using XmlRpc;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    /// <summary>
    /// Represents an XmlRpc Client. Implements the <see cref="IXmlRpcClient"/> interface.
    /// </summary>
    [UsedImplicitly]
    public sealed class XmlRpcClient : IXmlRpcClient, IDisposable
    {
        /// <summary>
        /// A uint with a 1 at the highest bit.
        /// If the request handle is 0 after performing a bitwise AND ond this then it's a server callback.
        /// </summary>
        private const uint serverCallbackMask = 0x80000000;

        private static readonly Decoder utf8Decoder = Encoding.UTF8.GetDecoder();
        private readonly ConcurrentQueue<Message> messageQueue = new ConcurrentQueue<Message>();
        private readonly object writerLock = new object();
        private Thread eventDispatcherThread;
        private Thread receiveLoopThread;
        private uint requestHandle = serverCallbackMask;
        private Stream stream;
        private StreamWriter writer;

        /// <summary>
        /// Gets the configuration of this client.
        /// </summary>
        public Config Configuration { get; private set; }

        /// <summary>
        /// Gets the name of the Client.
        /// </summary>
        public string Name
        {
            get { return Configuration.Address + ":" + Configuration.Port; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.XmlRpcClient"/> class with the given configuration.
        /// </summary>
        /// <param name="config">The configuration to be used.</param>
        public XmlRpcClient(Config config)
        {
            Configuration = config;
        }

        /// <summary>
        /// Frees the unmanaged resources used by this class.
        /// </summary>
        public void Dispose()
        {
            //writer disposes stream too.
            writer.Dispose();
        }

        /// <summary>
        /// Stops the Threads for receiving data and dispatching events, and closes the connection.
        /// </summary>
        public void EndReceive()
        {
            receiveLoopThread.Abort();
            eventDispatcherThread.Abort();

            //Writer closes and disposes the stream.
            writer.Close();
            writer.Dispose();
        }

        /// <summary>
        /// Sends a method call to the server and returns the request handle associated with the call.
        /// </summary>
        /// <param name="request">The xml formatted call.</param>
        /// <returns>The request handle associated with the call.</returns>
        public uint SendRequest(string request)
        {
            lock (writerLock)
            {
                requestHandle++;

                request = asciify(request);

                var bytes = new List<byte>();
                bytes.AddRange(BitConverter.GetBytes((uint)request.Length));
                bytes.AddRange(BitConverter.GetBytes(requestHandle));

                stream.Write(bytes.ToArray(), 0, bytes.Count);
                stream.Flush();

                writer.Write(request);
                writer.Flush();

                return requestHandle;
            }
        }

        /// <summary>
        /// Connects to the XmlRpc server and starts Threads for receiving data from the opened connection and dispatching the appropriate events.
        /// </summary>
        public void StartReceive()
        {
            connect();

            receiveLoopThread = new Thread(receiveLoop)
            {
                Name = Name + " Receive Loop",
                IsBackground = true
            };

            eventDispatcherThread = new Thread(eventDispatcher)
            {
                Name = Name + " Event Dispatcher",
                IsBackground = true
            };

            receiveLoopThread.Start();
            eventDispatcherThread.Start();
        }

        private string asciify(string input)
        {
            var asciiBuilder = new StringBuilder(input.Length);
            foreach (var c in input.ToCharArray())
            {
                // ASCII uses 7 bits; Range: 0-127
                if (c < 128)
                    asciiBuilder.Append(c);
                else
                    asciiBuilder.Append("&#" + (int)c + ";");
            }

            return asciiBuilder.ToString();
        }

        /// <summary>
        /// Opens a connection to the Address and Port specified in the Config.
        /// </summary>
        private void connect()
        {
            stream = new TcpClient(Configuration.Address, Configuration.Port).GetStream();
            writer = new StreamWriter(stream, Encoding.ASCII);

            var protocolNameLengthBytes = new byte[4];
            stream.Read(protocolNameLengthBytes, 0, 4);
            uint protocolNameLength = BitConverter.ToUInt32(protocolNameLengthBytes, 0);

            if (protocolNameLength != 11)
                throw new Exception("Wrong Low-Level Protocol Header");

            string protocolName = decodeBytes(read(11));

            if (protocolName != "GBXRemote 2")
                throw new Exception("Wrong Low-Level Protocol Version");
        }

        /// <summary>
        /// Takes a byte array and decodes it into a string, based on UTF8 character values.
        /// </summary>
        /// <param name="bytes">The string as byte array.</param>
        /// <returns>The decoded string.</returns>
        private string decodeBytes(byte[] bytes)
        {
            var chars = new char[bytes.Length];
            int usedBytes;
            int usedChars;
            bool complete;
            utf8Decoder.Convert(bytes, 0, bytes.Length, chars, 0, bytes.Length, true, out usedBytes, out usedChars, out complete);

            return new string(chars.Take(usedChars).ToArray());
        }

        private void eventDispatcher()
        {
            while (true)
            {
                Message message;
                if (messageQueue.TryDequeue(out message))
                {
                    if ((message.Handle & serverCallbackMask) == 0)
                    {
                        //Message is a server callback
                        onServerCallback(message.Content);
                    }
                    else
                    {
                        //Message is a method response
                        onMethodResponse(message.Handle, message.Content);
                    }
                }
                else //If it couldn't dequeue a Message, it means there's none waiting.
                    Thread.Sleep(100);
            }
            // ReSharper disable once FunctionNeverReturns
        }

        /// <summary>
        /// Fires the ConnectionDroppedUnexpectedly event.
        /// </summary>
        /// <param name="cause">The Exception that caused the dropping.</param>
        private void onConnectionDroppedUnexpectedly(Exception cause)
        {
            if (ConnectionDroppedUnexpectedly != null)
                ConnectionDroppedUnexpectedly(this, cause);
        }

        /// <summary>
        /// Fires the MethodResponse event.
        /// </summary>
        /// <param name="messageHandle">The request handle of the method response.</param>
        /// <param name="methodResponse">The xml formatted method response string.</param>
        private void onMethodResponse(uint messageHandle, string methodResponse)
        {
            if (MethodResponse != null)
                MethodResponse(this, messageHandle, methodResponse);
        }

        /// <summary>
        /// Fires the ServerCallback event.
        /// </summary>
        /// <param name="serverCallback">The xml formatted server callback string.</param>
        private void onServerCallback(string serverCallback)
        {
            if (ServerCallback != null)
                ServerCallback(this, serverCallback);
        }

        /// <summary>
        /// Reads count number of bytes from the stream and returns them in an array.
        /// </summary>
        /// <param name="count">Number of bytes to read. Also size of the returned array.</param>
        /// <returns>count read bytes.</returns>
        private byte[] read(int count)
        {
            var result = new byte[count];
            int offset = 0;

            while (count - offset > 0)
                offset += stream.Read(result, offset, count - offset);

            return result;
        }

        private void receiveLoop()
        {
            var messageHeaderBytes = new byte[8];

            while (true)
            {
                try
                {
                    messageHeaderBytes = read(8);
                    uint messageLength = BitConverter.ToUInt32(messageHeaderBytes, 0);
                    uint messageHandle = BitConverter.ToUInt32(messageHeaderBytes, 4);

                    string messageContent = decodeBytes(read((int)messageLength));

                    messageQueue.Enqueue(new Message(messageHandle, messageContent));
                }
                catch (ThreadAbortException)
                {
                    //If it's a thread abort exception, the connection didn't drop unexpectedly.
                    break;
                }
                catch (Exception ex)
                {
                    //If anything goes wrong with the message reading, it's most likely the connection dropping.
                    onConnectionDroppedUnexpectedly(ex);
                    break;
                }
            }
        }

        /// <summary>
        /// Fires when the connection is dropped unexpectedly.
        /// </summary>
        public event ConnectionDroppedUnexpectedlyEventHandler ConnectionDroppedUnexpectedly;

        /// <summary>
        /// Fires when a MethodResponse is received.
        /// </summary>
        public event MethodResponseEventHandler MethodResponse;

        /// <summary>
        /// Fires when a ServerCallback is received.
        /// </summary>
        public event ServerCallbackEventHandler ServerCallback;

        /// <summary>
        /// Represents a configuration for the XmlRpcClient.
        /// </summary>
        public class Config
        {
            /// <summary>
            /// Gets the address of the server that the client connects to.
            /// </summary>
            public string Address { get; private set; }

            /// <summary>
            /// Gets the port that the client connects to.
            /// </summary>
            public int Port { get; private set; }

            /// <summary>
            /// Creates a new instance of the <see cref="XmlRpc.XmlRpcClient.Config"/> class with the given address and port.
            /// </summary>
            /// <param name="address">The address that the client connects to; Localhost by default.</param>
            /// <param name="port">The port that the client connects to; 5000 by default.</param>
            public Config(string address = "localhost", int port = 5000)
            {
                Address = address;
                Port = port;
            }
        }

        private class Message
        {
            public string Content { get; private set; }

            public uint Handle { get; private set; }

            public Message(uint handle, string content)
            {
                Handle = handle;
                Content = content;
            }
        }
    }
}