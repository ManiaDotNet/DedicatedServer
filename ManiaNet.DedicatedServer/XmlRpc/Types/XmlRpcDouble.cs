using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcDouble : XmlRpcType<double>
    {
        public override string ElementName
        {
            get { return "double"; }
        }

        public override XmlRpcType<double> ParseXml(XElement xElement)
        {
            checkName(xElement);

            Value = double.Parse(xElement.Value);

            return this;
        }
    }
}