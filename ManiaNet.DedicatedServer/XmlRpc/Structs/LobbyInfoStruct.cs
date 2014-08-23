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
    /// Represents the struct returned by the GetLobbyInfo method call.
    /// </summary>
    public sealed class LobbyInfoStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the IsLobby property.
        /// </summary>
        private readonly XmlRpcBoolean isLobby = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the LobbyMaxPlayers property.
        /// </summary>
        private readonly XmlRpcI4 lobbyMaxPlayers = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LobbyPlayers property.
        /// </summary>
        private readonly XmlRpcI4 lobbyPlayers = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LobbyPlayersLevel property.
        /// </summary>
        private readonly XmlRpcDouble lobbyPlayersLevel = new XmlRpcDouble();

        /// <summary>
        /// Gets whether this server is a lobby or not.
        /// </summary>
        [UsedImplicitly]
        public bool IsLobby
        {
            get { return isLobby.Value; }
        }

        /// <summary>
        /// Gets the maximum number of players in the lobby.
        /// </summary>
        [UsedImplicitly]
        public int LobbyMaxPlayers
        {
            get { return lobbyMaxPlayers.Value; }
        }

        /// <summary>
        /// Gets the current number of players in the lobby.
        /// </summary>
        [UsedImplicitly]
        public int LobbyPlayers
        {
            get { return lobbyPlayers.Value; }
        }

        /// <summary>
        /// Gets the level of the players in the lobby.
        /// </summary>
        [UsedImplicitly]
        public double LobbyPlayersLevel
        {
            get { return lobbyPlayersLevel.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("IsLobby", isLobby),
                makeMemberElement("LobbyPlayers", lobbyPlayers),
                makeMemberElement("LobbyMaxPlayers", lobbyMaxPlayers),
                makeMemberElement("LobbyPlayersLevel", lobbyPlayersLevel));
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
                case "IsLobby":
                    if (!isLobby.ParseXml(value))
                        return false;
                    break;

                case "LobbyPlayers":
                    if (!lobbyPlayers.ParseXml(value))
                        return false;
                    break;

                case "LobbyMaxPlayers":
                    if (!lobbyMaxPlayers.ParseXml(value))
                        return false;
                    break;

                case "LobbyPlayersLevel":
                    if (!lobbyPlayersLevel.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}