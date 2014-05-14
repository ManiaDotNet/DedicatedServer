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
        private Protocol protocol;
        private StreamReader reader;
        private uint requestHandle = 0;
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
            reader = new StreamReader(stream, Encoding.UTF8);
            writer = new StreamWriter(stream, Encoding.UTF8);

            byte[] protocolNameLengthBytes = new byte[4];
            stream.Read(protocolNameLengthBytes, 0, 4);
            uint protocolNameLength = BitConverter.ToUInt32(protocolNameLengthBytes, 0);

            if (protocolNameLength > 64)
                throw new Exception("Wrong Low-Level Protocol Header");

            char[] protocolName = new char[protocolNameLength];
            reader.ReadBlock(protocolName, 0, (int)protocolNameLength);
            switch (new string(protocolName))
            {
                case "GBXRemote 1":
                    protocol = Protocol.GbxRemoteOne;
                    break;

                case "GBXRemote 2":
                    protocol = Protocol.GbxRemoteTwo;
                    break;

                default:
                    throw new Exception("Wrong Low-Level Protocol Version");
            }
        }

        public void Receive()
        {
            char[] chars = new char[1];
            while (true)
            {
                reader.ReadBlock(chars, 0, 1);
                Console.WriteLine(chars[0]);
            }
        }

        public void Send(string request)
        {
            requestHandle++;
            List<byte> bytes = new List<byte>(BitConverter.GetBytes((uint)request.Length));

            //GBXRemote 1 only takes the length
            if (protocol == Protocol.GbxRemoteTwo)
            {
                bytes.AddRange(BitConverter.GetBytes((uint)1));
            }

            //stream.Write(bytes.ToArray(), 0, bytes.Count);
            //writer.Write(request);

            byte[] requestBytes = new byte[request.Length];
            Encoding.ASCII.GetEncoder().GetBytes(request.ToCharArray(), 0, request.Length, requestBytes, 0, true);
            bytes.AddRange(requestBytes);
            foreach (byte b in bytes)
            {
                Console.Write(b + "-");
            }
            Console.WriteLine();
            stream.Write(bytes.ToArray(), 0, bytes.Count);
            stream.Flush();
        }

        private enum Protocol
        {
            GbxRemoteOne = 1,
            GbxRemoteTwo = 2
        }
    }
}