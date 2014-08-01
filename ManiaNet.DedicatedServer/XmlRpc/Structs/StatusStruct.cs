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
    /// Represents the struct returned by the GetStatus method call.
    /// </summary>
    public sealed class StatusStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Code property.
        /// </summary>
        private readonly XmlRpcI4 code = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private readonly XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Gets the Code for the current status of the server application.
        /// </summary>
        public int Code
        {
            get { return code.Value; }
        }

        /// <summary>
        /// Gets the Name for the current status of the server application.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Code", code),
                makeMemberElement("Name", name));
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

                case "Code":
                    if (!code.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}