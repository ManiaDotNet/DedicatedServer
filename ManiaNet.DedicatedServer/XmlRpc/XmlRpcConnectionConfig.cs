using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    public class XmlRpcConnectionConfig
    {
        public string Address { get; private set; }

        public string Password { get; private set; }

        public int Port { get; private set; }

        public string Username { get; private set; }

        public XmlRpcConnectionConfig(string address = "localhost", int port = 5000, string username = "SuperAdmin", string password = "SuperAdmin")
        {
            Address = address;
            Port = port;
            Username = username;
            Password = password;
        }
    }
}