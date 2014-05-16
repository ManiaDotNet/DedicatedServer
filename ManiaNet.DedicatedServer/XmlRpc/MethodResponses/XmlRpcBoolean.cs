using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodResponses
{
    public class XmlRpcBoolean : XmlRpcMethodResponse<XmlRpcBoolean, bool>
    {
        public override XmlRpcBoolean ParseXml(string methodResponse)
        {
            switch (XDocument.Parse(methodResponse).Descendants().Single(element => element.Name.LocalName.ToLower() == "boolean").Value.ToLower())
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