using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcBase64 : XmlRpcType<byte[]>
    {
        public override string ElementName
        {
            get { return "base64"; }
        }

        public XmlRpcBase64()
        {
            Value = new byte[0];
        }

        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName), Convert.ToBase64String(Value));
        }

        public override XmlRpcType<byte[]> ParseXml(XElement xElement)
        {
            checkName(xElement);

            Value = Convert.FromBase64String(xElement.Value);

            return this;
        }
    }
}