using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcBoolean : XmlRpcType<bool>
    {
        public override string ElementName
        {
            get { return "boolean"; }
        }

        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName), Value ? 1 : 0);
        }

        public override XmlRpcType<bool> ParseXml(XElement xElement)
        {
            checkName(xElement);

            switch (xElement.Value.ToLower())
            {
                case "false":
                case "0":
                    Value = false;
                    break;

                case "true":
                case "1":
                    Value = true;
                    break;

                default:
                    throw new FormatException("Boolean format not recognized");
            }

            return this;
        }
    }
}