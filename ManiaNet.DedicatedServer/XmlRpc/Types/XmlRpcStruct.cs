using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcStruct<TXmlRpcStruct> : XmlRpcType<TXmlRpcStruct> where TXmlRpcStruct : Structs.XmlRpcStruct<TXmlRpcStruct>, new()
    {
        public override string ElementName
        {
            get { return "struct"; }
        }

        public XmlRpcStruct()
        {
            Value = new TXmlRpcStruct();
        }

        public override XElement GenerateXml()
        {
            XElement strct = new XElement(XName.Get(ElementName));
            strct.Add(Value.GenerateXml().ToArray());
            return strct;
        }

        public override XmlRpcType<TXmlRpcStruct> ParseXml(XElement xElement)
        {
            checkName(xElement);

            Value.ParseXml(xElement);

            return this;
        }
    }
}