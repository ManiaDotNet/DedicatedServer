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
    /// Represents the structs returned by the GetBanList method call.
    /// </summary>
    public sealed class BanInfoStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the ClientName property.
        /// </summary>
        private readonly XmlRpcString clientName = new XmlRpcString();

        /// <summary>
        /// Backing field for the IPAddress property.
        /// </summary>
        private readonly XmlRpcString ipAddress = new XmlRpcString();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private readonly XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Gets the ClientName of the banned player.
        /// </summary>
        public string ClientName
        {
            get { return clientName.Value; }
        }

        /// <summary>
        /// Gets the IP-address of the banned player.
        /// </summary>
        public string IPAddress
        {
            get { return ipAddress.Value; }
        }

        /// <summary>
        /// Gets the Login of the banned player.
        /// </summary>
        public string Login
        {
            get { return login.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Login", login),
                makeMemberElement("ClientName", clientName),
                makeMemberElement("IPAddress", ipAddress));
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
                case "Login":
                    if (!login.ParseXml(value))
                        return false;
                    break;

                case "ClientName":
                    if (!clientName.ParseXml(value))
                        return false;
                    break;

                case "IPAddress":
                    if (!ipAddress.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}