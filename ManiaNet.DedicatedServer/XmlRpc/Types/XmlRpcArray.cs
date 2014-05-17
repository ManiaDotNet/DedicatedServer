using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public class XmlRpcArray<TArray, TBase> : XmlRpcType<TArray[]> where TArray : XmlRpcType<TBase>, new()
    {
        public const string DataElement = "data";

        public const string ValueElement = "value";

        public override string ElementName
        {
            get { return "array"; }
        }

        public XmlRpcArray()
        {
            Value = new TArray[0];
        }

        public override XElement GenerateXml()
        {
            XElement array = new XElement(XName.Get(this.ElementName));

            XElement data = new XElement(XName.Get("data"));
            foreach (TArray value in Value)
            {
                XElement valueElement = new XElement(XName.Get("value"));
                valueElement.Add(value.GenerateXml());
                data.Add(valueElement);
            }

            array.Add(data);
            return array;
        }

        public override XmlRpcType<TArray[]> ParseXml(XElement xElement)
        {
            checkName(xElement);
            List<TArray> content = new List<TArray>();

            foreach (XElement valueElement in xElement.Element(XName.Get(DataElement)).Elements(XName.Get(ValueElement)))
            {
                TArray value = new TArray();

                if (valueElement.HasElements)
                {
                    XElement valueContentElement = valueElement.Element(XName.Get(value.ElementName));

                    if (valueContentElement == null)
                        throw new FormatException("Value Content isn't of the expected type. Expected: " + value.ElementName);

                    value.ParseXml(valueElement.Elements().First());
                }
                else if (value.ElementName == "string") //default type for value is string
                {
                    value.ParseXml(new XElement(XName.Get("string"), valueElement.Value));
                }
                else
                {
                    throw new FormatException("Content of value tag is not a tag, and type of the array isn't String");
                }

                content.Add(value);
            }

            Value = content.ToArray();
            return this;
        }
    }
}