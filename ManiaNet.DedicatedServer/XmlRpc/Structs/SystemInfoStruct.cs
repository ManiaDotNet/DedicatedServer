using ManiaNet.DedicatedServer.Annotations;
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
    /// Represents the struct returned by the GetSystemInfo method call.
    /// </summary>
    public sealed class SystemInfoStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the ConnectionDownloadRate property.
        /// </summary>
        private readonly XmlRpcI4 connectionDownloadRate = new XmlRpcI4();

        /// <summary>
        /// Backing field for the ConnectionUploadRate property.
        /// </summary>
        private readonly XmlRpcI4 connectionUploadRate = new XmlRpcI4();

        /// <summary>
        /// Backing field for the IsDedicated property.
        /// </summary>
        private readonly XmlRpcBoolean isDedicated = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the IsServer property.
        /// </summary>
        private readonly XmlRpcBoolean isServer = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the P2PPort property.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        private readonly XmlRpcI4 p2pPort = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Port property.
        /// </summary>
        private readonly XmlRpcI4 port = new XmlRpcI4();

        /// <summary>
        /// Backing field for the PublishedIp property.
        /// </summary>
        private readonly XmlRpcString publishedIp = new XmlRpcString();

        /// <summary>
        /// Backing field for the ServerLogin property.
        /// </summary>
        private readonly XmlRpcString serverLogin = new XmlRpcString();

        /// <summary>
        /// Backing field for the ServerPlayerId property.
        /// </summary>
        private readonly XmlRpcI4 serverPlayerId = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TitleId property.
        /// </summary>
        private readonly XmlRpcString titleId = new XmlRpcString();

        /// <summary>
        /// Gets the maximum download rate of the server. In kBits per second.
        /// </summary>
        [UsedImplicitly]
        public int ConnectionDownloadRate
        {
            get { return connectionDownloadRate.Value; }
        }

        /// <summary>
        /// Gets the maximum upload rate of the server. In kbits per second.
        /// </summary>
        [UsedImplicitly]
        public int ConnectionUploadRate
        {
            get { return connectionUploadRate.Value; }
        }

        /// <summary>
        /// Gets whether the server is dedicated or not.
        /// </summary>
        [UsedImplicitly]
        public bool IsDedicated
        {
            get { return isDedicated.Value; }
        }

        /// <summary>
        /// Gets whether the server is a server or not.
        /// </summary>
        [UsedImplicitly]
        public bool IsServer
        {
            get { return isServer.Value; }
        }

        /// <summary>
        /// Gets the port number that the server uses for p2p connections.
        /// </summary>
        [UsedImplicitly]
        public int P2PPort
        {
            get { return p2pPort.Value; }
        }

        /// <summary>
        /// Gets the port number that the server uses for connecting players.
        /// </summary>
        [UsedImplicitly]
        public int Port
        {
            get { return port.Value; }
        }

        /// <summary>
        /// Gets the IP-address that the server published to the master server.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string PublishedIp
        {
            get { return publishedIp.Value; }
        }

        /// <summary>
        /// Gets the login of the server account.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ServerLogin
        {
            get { return serverLogin.Value; }
        }

        /// <summary>
        /// Gets the player Id of the server.
        /// </summary>
        [UsedImplicitly]
        public int ServerPlayerId
        {
            get { return serverPlayerId.Value; }
        }

        /// <summary>
        /// Gets the ID of the Title that's currently being played (TMCanyon, TMValley, etc.) on the server.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string TitleId
        {
            get { return titleId.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("PublishedIp", publishedIp),
                makeMemberElement("Port", port),
                makeMemberElement("P2PPort", p2pPort),
                makeMemberElement("TitleId", titleId),
                makeMemberElement("ServerLogin", serverLogin),
                makeMemberElement("ServerPlayerId", serverPlayerId),
                makeMemberElement("ConnectionDownloadRate", connectionDownloadRate),
                makeMemberElement("ConnectionUploadRate", connectionUploadRate),
                makeMemberElement("IsServer", isServer),
                makeMemberElement("IsDedicated", isDedicated));
        }

        /// <summary>
        /// Fills the property of this struct that has the correct name with the information contained in the member-XElement.
        /// </summary>
        /// <param name="member">The member element storing the information.</param>
        /// <returns>Whether it was successful or not.</returns>
        protected override bool parseXml(XElement member)
        {
            var value = getMemberValueElement(member);

            switch (getMemberName(member))
            {
                case "PublishedIp":
                    if (!publishedIp.ParseXml(value))
                        return false;
                    break;

                case "Port":
                    if (!port.ParseXml(value))
                        return false;
                    break;

                case "P2PPort":
                    if (!p2pPort.ParseXml(value))
                        return false;
                    break;

                case "TitleId":
                    if (!titleId.ParseXml(value))
                        return false;
                    break;

                case "ServerLogin":
                    if (!serverLogin.ParseXml(value))
                        return false;
                    break;

                case "ServerPlayerId":
                    if (!serverPlayerId.ParseXml(value))
                        return false;
                    break;

                case "ConnectionDownloadRate":
                    if (!connectionDownloadRate.ParseXml(value))
                        return false;
                    break;

                case "ConnectionUploadRate":
                    if (!connectionUploadRate.ParseXml(value))
                        return false;
                    break;

                case "IsServer":
                    if (!isServer.ParseXml(value))
                        return false;
                    break;

                case "IsDedicated":
                    if (!isDedicated.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}