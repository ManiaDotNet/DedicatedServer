using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types
{
    public abstract class XmlRpcType<TValue>
    {
        public abstract string ElementName { get; }

        public TValue Value { get; set; }

        /// <summary>
        /// Generates Xml from the Value. Default implementation creates an element with the ElementName and the content from Value.
        /// </summary>
        /// <returns>The generated Xml.</returns>
        public virtual XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName), Value);
        }

        public abstract XmlRpcType<TValue> ParseXml(XElement xElement);

        protected void checkName(XElement xElement)
        {
            if (!xElement.Name.LocalName.Equals(ElementName))
                throw new ArgumentException("Element has to have the name " + ElementName, "xElement");
        }
    }
}