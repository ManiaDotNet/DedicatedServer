using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    public class XmlRpcConnection
    {
        private StreamReader reader;
        private uint requestHandle = 0x80000000;
        private Stream stream;
        private StreamWriter writer;

        public XmlRpcConnectionConfig Config { get; private set; }

        public XmlRpcConnection(XmlRpcConnectionConfig config)
        {
            Config = config;
        }

        public void Connect()
        {
            stream = new TcpClient(Config.Address, Config.Port).GetStream();
            reader = new StreamReader(stream, Encoding.ASCII);
            writer = new StreamWriter(stream, Encoding.ASCII);

            byte[] protocolNameLengthBytes = new byte[4];
            stream.Read(protocolNameLengthBytes, 0, 4);
            uint protocolNameLength = BitConverter.ToUInt32(protocolNameLengthBytes, 0);

            if (protocolNameLength != 11)
                throw new Exception("Wrong Low-Level Protocol Header");

            char[] protocolName = new char[protocolNameLength];
            reader.ReadBlock(protocolName, 0, (int)protocolNameLength);

            if (new string(protocolName) != "GBXRemote 2")
                throw new Exception("Wrong Low-Level Protocol Version");
        }

        public void Receive()
        {
            byte[] messageHeaderBytes = new byte[8];
            uint messageLength;
            uint messageRequestHandle;

            while (true)
            {
                stream.Read(messageHeaderBytes, 0, 8);
                messageLength = BitConverter.ToUInt32(messageHeaderBytes, 0);
                messageRequestHandle = BitConverter.ToUInt32(messageHeaderBytes, 4);

                byte[] messageCharBytes = new byte[messageLength];
                int offset = 0;

                while (messageLength - offset > 0)
                    offset += stream.Read(messageCharBytes, offset, ((int)messageLength) - offset);

                char[] messageChars = new char[messageLength];
                int usedBytes;
                int usedChars;
                bool complete;
                Encoding.ASCII.GetDecoder().Convert(messageCharBytes, 0, (int)messageLength, messageChars, 0, (int)messageLength, true, out usedBytes, out usedChars, out complete);

                if ((messageRequestHandle & 0x80000000) == 0)
                {
                    //This is a server callback
                    Console.WriteLine("Server Callback");
                }
                else
                {
                    //This is a method response
                    Console.WriteLine("Method Response for handle: " + messageRequestHandle);
                }

                Console.WriteLine(new string(messageChars));
            }
        }

        public uint Send(string request)
        {
            requestHandle++;

            List<byte> bytes = new List<byte>();
            bytes.AddRange(BitConverter.GetBytes((uint)request.Length));
            bytes.AddRange(BitConverter.GetBytes((uint)requestHandle));

            stream.Write(bytes.ToArray(), 0, bytes.Count);
            stream.Flush();

            writer.Write(request);
            writer.Flush();

            return requestHandle;
        }

        public delegate void MethodResponseEventHandler(XmlRpcMethodResponse methodResponse);

        public delegate void ServerCallbackEventHandler(XmlRpcServerCallback serverCallback);

        public event MethodResponseEventHandler MethodResponse;

        public event ServerCallbackEventHandler ServerCallback;
    }
}