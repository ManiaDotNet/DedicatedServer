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
    /// Represents the struct passed to the JoinServerLan and JoinServerInternet method calls.
    /// </summary>
    public sealed class JoinServerStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private readonly XmlRpcString server = new XmlRpcString();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private readonly XmlRpcString serverPassword = new XmlRpcString();

        /// <summary>
        /// Gets or sets the IP address of the server to connect to.
        /// </summary>
        public string Server
        {
            get { return server.Value; }
            set { server.Value = value; }
        }

        /// <summary>
        /// Gets or sets the password used to connect to the server.
        /// </summary>
        public string ServerPassword
        {
            get { return serverPassword.Value; }
            set { serverPassword.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.JoinServerStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public JoinServerStruct()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.JoinServerStruct"/> class with the given ip address and password.
        /// </summary>
        /// <param name="server">The IP address of the tserver to connect to.</param>
        /// <param name="serverPassword">The password used to connect to the server.</param>
        public JoinServerStruct(string server, string serverPassword)
        {
            Server = server;
            ServerPassword = serverPassword;
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Server", server),
                makeMemberElement("ServerPassword", serverPassword));
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
                case "Server":
                    if (!server.ParseXml(value))
                        return false;
                    break;

                case "ServerPassword":
                    if (!serverPassword.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}