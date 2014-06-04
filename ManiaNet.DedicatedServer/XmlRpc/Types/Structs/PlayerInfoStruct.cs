using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetPlayerList, GetPlayerInfo, and GetMainServerPlayerInfo method calls.
    /// </summary>
    public sealed class PlayerInfoStruct : BaseStruct<PlayerInfoStruct>
    {
        /// <summary>
        /// Backing field for the IsInOfficialMode property.
        /// </summary>
        private XmlRpcBoolean isInOfficialMode = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the IsSpectator property.
        /// </summary>
        private XmlRpcBoolean isSpectator = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the LadderRanking property.
        /// </summary>
        private XmlRpcI4 ladderRanking = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Backing field for the NickName property.
        /// </summary>
        private XmlRpcString nickName = new XmlRpcString();

        /// <summary>
        /// Backing field for the PlayerId property.
        /// </summary>
        private XmlRpcI4 playerId = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TeamId property.
        /// </summary>
        private XmlRpcI4 teamId = new XmlRpcI4();

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
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Login", login.GenerateXml()),
                makeMemberElement("NickName", nickName.GenerateXml()),
                makeMemberElement("PlayerId", playerId.GenerateXml()),
                makeMemberElement("TeamId", teamId.GenerateXml()),
                makeMemberElement("IsSpectator", isSpectator.GenerateXml()),
                makeMemberElement("IsInOfficialMode", isInOfficialMode.GenerateXml()),
                makeMemberElement("LadderRanking", ladderRanking.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override PlayerInfoStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Login":
                        login.ParseXml(getValueContent(value, login.ElementName));
                        break;

                    case "NickName":
                        nickName.ParseXml(getValueContent(value, nickName.ElementName));
                        break;

                    case "PlayerId":
                        playerId.ParseXml(getValueContent(value, playerId.ElementName));
                        break;

                    case "TeamId":
                        teamId.ParseXml(getValueContent(value, teamId.ElementName));
                        break;

                    case "IsSpectator":
                        isSpectator.ParseXml(getValueContent(value, isSpectator.ElementName));
                        break;

                    case "IsInOfficialMode":
                        isInOfficialMode.ParseXml(getValueContent(value, isInOfficialMode.ElementName));
                        break;

                    case "LadderRanking":
                        ladderRanking.ParseXml(getValueContent(value, ladderRanking.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}