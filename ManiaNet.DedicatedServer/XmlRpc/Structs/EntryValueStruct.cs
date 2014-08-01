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
    /// Represents a struct passed to the ManiaPlanet.PlayerManialinkPageAnswer callback method.
    /// </summary>
    public sealed class EntryValueStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private readonly XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the Value property.
        /// </summary>
        private readonly XmlRpcString value = new XmlRpcString();

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Name", name),
                makeMemberElement("Value", value));
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
                case "Name":
                    if (!name.ParseXml(value))
                        return false;
                    break;

                case "Value":
                    if (!this.value.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}