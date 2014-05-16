using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    public abstract class XmlRpcMethodResponse<TXmlRpc, TValue>
    {
        public TValue Value { get; protected set; }

        public abstract TXmlRpc ParseXml(string methodResponse);
    }
}