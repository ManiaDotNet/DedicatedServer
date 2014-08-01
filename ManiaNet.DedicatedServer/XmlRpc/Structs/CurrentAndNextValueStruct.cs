using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the struct returned by various method calls.
    /// </summary>
    public sealed class CurrentAndNextValueStruct<TXmlRpcType, TBase> : BaseStruct
        where TXmlRpcType : XmlRpcType<TBase>, new()
    {
        /// <summary>
        /// Backing field for the CurrentValue property.
        /// </summary>
        private readonly TXmlRpcType currentValue = new TXmlRpcType();

        /// <summary>
        /// Backing field for the NextValue property.
        /// </summary>
        private readonly TXmlRpcType nextValue = new TXmlRpcType();

        /// <summary>
        /// Gets the current value.
        /// </summary>
        public TBase CurrentValue
        {
            get { return currentValue.Value; }
        }

        /// <summary>
        /// Gets the next value.
        /// </summary>
        public TBase NextValue
        {
            get { return nextValue.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("CurrentValue", currentValue),
                makeMemberElement("NextValue", nextValue));
        }

        /// <summary>
        /// Fills the property of this struct that has the correct name with the information contained in the member-XElement.
        /// </summary>
        /// <param name="member">The member element storing the information.</param>
        /// <returns>Whether it was successful or not.</returns>
        protected override bool parseXml(XElement member)
        {
            XElement value = getMemberValueElement(member);

            switch (getMemberName(member))
            {
                case "CurrentValue":
                    if (!currentValue.ParseXml(value))
                        return false;
                    break;

                case "NextValue":
                    if (!nextValue.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}