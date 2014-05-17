using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcInt : XmlRpcType<int>
    {
        public override string ElementName
        {
            get { return "int"; }
        }

        public override XmlRpcType<int> ParseXml(XElement xElement)
        {
            checkName(xElement);

            Value = int.Parse(xElement.Value);

            return this;
        }
    }
}