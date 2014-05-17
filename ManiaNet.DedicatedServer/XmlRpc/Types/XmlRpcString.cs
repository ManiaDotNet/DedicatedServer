using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcString : XmlRpcType<string>
    {
        public override string ElementName
        {
            get { return "string"; }
        }

        public XmlRpcString()
        {
            Value = string.Empty;
        }

        public override XmlRpcType<string> ParseXml(XElement xElement)
        {
            checkName(xElement);

            Value = xElement.Value;

            return this;
        }
    }
}