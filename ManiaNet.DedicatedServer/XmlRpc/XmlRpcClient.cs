using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    public sealed class XmlRpcClient : IXmlRpcClient
    {
        private const uint serverCallbackHandle = 0x80000000;

        private uint requestHandle = serverCallbackHandle;

        private Stream stream;
        private StreamWriter writer;

        public XmlRpcClientConfig Config { get; private set; }

        public XmlRpcClient(XmlRpcClientConfig config)
        {
            Config = config;
        }

        /// <summary>
        /// Opens a connection to the Address and Port specified in the Config.
        /// </summary>
        public void Connect()
        {
            stream = new TcpClient(Config.Address, Config.Port).GetStream();
            writer = new StreamWriter(stream, Encoding.ASCII);

            byte[] protocolNameLengthBytes = new byte[4];
            stream.Read(protocolNameLengthBytes, 0, 4);
            uint protocolNameLength = BitConverter.ToUInt32(protocolNameLengthBytes, 0);

            if (protocolNameLength != 11)
                throw new Exception("Wrong Low-Level Protocol Header");

            string protocolName = decodeBytes(read(11));

            if (protocolName != "GBXRemote 2")
                throw new Exception("Wrong Low-Level Protocol Version");
        }

        public void Receive()
        {
            byte[] messageHeaderBytes = new byte[8];
            uint messageLength;
            uint messageHandle;

            while (true)
            {
                stream.Read(messageHeaderBytes, 0, 8);
                messageLength = BitConverter.ToUInt32(messageHeaderBytes, 0);
                messageHandle = BitConverter.ToUInt32(messageHeaderBytes, 4);

                string message = decodeBytes(read((int)messageLength));

                if ((messageHandle & serverCallbackHandle) == 0)
                {
                    //This is a server callback
                    Console.WriteLine("Server Callback");
                    onServerCallback(message);
                }
                else
                {
                    //This is a method response
                    Console.WriteLine("Method Response for handle: " + messageHandle);
                    onMethodResponse(messageHandle, message);
                }

                Console.WriteLine(message);
            }
        }

        /// <summary>
        /// Sends a method call to the server and returns the request handle associated with the call.
        /// </summary>
        /// <param name="request">The xml formatted call.</param>
        /// <returns>The request handle associated with the call.</returns>
        public uint SendRequest(string request)
        {
            requestHandle++;

            List<byte> bytes = new List<byte>();
            bytes.AddRange(BitConverter.GetBytes((uint)request.Length));
            bytes.AddRange(BitConverter.GetBytes(requestHandle));

            stream.Write(bytes.ToArray(), 0, bytes.Count);
            stream.Flush();

            writer.Write(request);
            writer.Flush();

            return requestHandle;
        }

        private string decodeBytes(byte[] bytes)
        {
            char[] chars = new char[bytes.Length];
            int usedBytes;
            int usedChars;
            bool complete;
            Encoding.ASCII.GetDecoder().Convert(bytes, 0, bytes.Length, chars, 0, bytes.Length, true, out usedBytes, out usedChars, out complete);

            return new string(chars);
        }

        private void onMethodResponse(uint messageHandle, string methodResponse)
        {
            if (MethodResponse != null)
                MethodResponse(messageHandle, methodResponse);
        }

        private void onServerCallback(string serverCallback)
        {
            if (ServerCallback != null)
                ServerCallback(serverCallback);
        }

        private byte[] read(int count)
        {
            byte[] result = new byte[count];
            int offset = 0;

            while (count - offset > 0)
                offset += stream.Read(result, offset, count - offset);

            return result;
        }

        public event MethodResponseEventHandler MethodResponse;

        public event ServerCallbackEventHandler ServerCallback;
    }
}