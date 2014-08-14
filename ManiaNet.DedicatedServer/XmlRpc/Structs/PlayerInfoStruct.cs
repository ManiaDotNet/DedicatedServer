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
    /// Represents the struct returned by the GetPlayerList, GetPlayerInfo, and GetMainServerPlayerInfo method calls.
    /// </summary>
    public sealed class PlayerInfoStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the IsInOfficialMode property.
        /// </summary>
        private readonly XmlRpcBoolean isInOfficialMode = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the IsSpectator property.
        /// </summary>
        private readonly XmlRpcBoolean isSpectator = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the LadderRanking property.
        /// </summary>
        private readonly XmlRpcI4 ladderRanking = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private readonly XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Backing field for the NickName property.
        /// </summary>
        private readonly XmlRpcString nickName = new XmlRpcString();

        /// <summary>
        /// Backing field for the PlayerId property.
        /// </summary>
        private readonly XmlRpcI4 playerId = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TeamId property.
        /// </summary>
        private readonly XmlRpcI4 teamId = new XmlRpcI4();

        /// <summary>
        /// Gets whether the player is in official mode or not.
        /// </summary>
        public bool IsInOfficialMode
        {
            get { return isInOfficialMode.Value; }
        }

        /// <summary>
        /// Gets whether the player is in spectator mode or not.
        /// </summary>
        public bool IsSpectator
        {
            get { return isSpectator.Value; }
        }

        /// <summary>
        /// Gets the player's ladder ranking on the continent (Europe, America, etc.).
        /// </summary>
        public int LadderRanking
        {
            get { return ladderRanking.Value; }
        }

        /// <summary>
        /// Gets the player's login.
        /// </summary>
        public string Login
        {
            get { return login.Value; }
        }

        /// <summary>
        /// Gets the player's nickname.
        /// </summary>
        public string NickName
        {
            get { return nickName.Value; }
        }

        /// <summary>
        /// Gets the player's id for the current session.
        /// </summary>
        public int PlayerId
        {
            get { return playerId.Value; }
        }

        /// <summary>
        /// Gets the id of the player's team. -1 if the player is not in a team.
        /// </summary>
        public int TeamId
        {
            get { return teamId.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Login", login),
                makeMemberElement("NickName", nickName),
                makeMemberElement("PlayerId", playerId),
                makeMemberElement("TeamId", teamId),
                makeMemberElement("IsSpectator", isSpectator),
                makeMemberElement("IsInOfficialMode", isInOfficialMode),
                makeMemberElement("LadderRanking", ladderRanking));
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

                case "NickName":
                    if (!nickName.ParseXml(value))
                        return false;
                    break;

                case "PlayerId":
                    if (!playerId.ParseXml(value))
                        return false;
                    break;

                case "TeamId":
                    if (!teamId.ParseXml(value))
                        return false;
                    break;

                case "IsSpectator":
                    if (!isSpectator.ParseXml(value))
                        return false;
                    break;

                case "IsInOfficialMode":
                    if (!isInOfficialMode.ParseXml(value))
                        return false;
                    break;

                case "LadderRanking":
                    if (!ladderRanking.ParseXml(value))
                        return false;
                    break;

                case "SpectatorStatus":
                    // TODO: Do something about spectator status.
                    // Should have 5 numerals, but method returns 7...
                    break;

                case "Flags":
                    //TODO: Do something about flags.
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}