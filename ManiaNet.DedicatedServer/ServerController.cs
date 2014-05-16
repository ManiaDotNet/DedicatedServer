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

        public ServerControllerConfig Config { get; private set; }

        public ServerController(IXmlRpcClient xmlRpcClient, ServerControllerConfig config)
        {
            this.xmlRpcClient = xmlRpcClient;
            Config = config;
        }

        private bool authenticate()
        {
            return awaitResponse(xmlRpcClient.SendRequest(new XmlRpcAuthenticate(Config.Login, Config.Password).GetXml()));
        }

        private bool awaitResponse(uint p)
        {
            throw new NotImplementedException();
        }
    }
}