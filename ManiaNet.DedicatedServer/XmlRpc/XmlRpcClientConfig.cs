using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    public class XmlRpcClientConfig
    {
        public string Address { get; private set; }

        public int Port { get; private set; }

        public XmlRpcClientConfig(string address = "localhost", int port = 5000)
        {
            Address = address;
            Port = port;
        }
    }
}