using ManiaNet.DedicatedServer.XmlRpc;
using ManiaNet.DedicatedServer.XmlRpc.MethodCalls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    public class ServerController
    {
        private IXmlRpcClient xmlRpcClient;

        public Config Configuration { get; private set; }

        public ServerController(IXmlRpcClient xmlRpcClient, Config config)
        {
            this.xmlRpcClient = xmlRpcClient;
            Configuration = config;
        }

        public void Start()
        {
            xmlRpcClient.StartReceive();
        }

        public void Stop()
        {
            xmlRpcClient.EndReceive();
        }

        private bool authenticate()
        {
            return awaitResponse(xmlRpcClient.SendRequest(new XmlRpcAuthenticate(Configuration.Login, Configuration.Password).GetXml()));
        }

        private bool awaitResponse(uint p)
        {
            throw new NotImplementedException();
        }

        public class Config
        {
            public string Login { get; private set; }

            public string Password { get; private set; }

            public Config(string login, string password)
            {
                Login = login;
                Password = password;
            }
        }
    }
}