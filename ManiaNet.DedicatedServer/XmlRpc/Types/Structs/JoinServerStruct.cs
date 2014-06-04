using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct passed to the JoinServerLan and JoinServerInternet method calls.
    /// </summary>
    public sealed class JoinServerStruct : BaseStruct<JoinServerStruct>
    {
        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private XmlRpcString server = new XmlRpcString();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private XmlRpcString serverPassword = new XmlRpcString();

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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Types.Structs.JoinServerStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public JoinServerStruct()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Types.Structs.JoinServerStruct"/> class with the given ip address and password.
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
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Server", server.GenerateXml()),
                makeMemberElement("ServerPassword", serverPassword.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override JoinServerStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Server":
                        server.ParseXml(getValueContent(value, server.ElementName));
                        break;

                    case "ServerPassword":
                        serverPassword.ParseXml(getValueContent(value, serverPassword.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}