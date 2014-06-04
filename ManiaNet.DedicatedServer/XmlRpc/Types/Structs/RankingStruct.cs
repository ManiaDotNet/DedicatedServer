using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the structs returned by the GetCurrentRanking and GetCurrentRankingForLogin method calls.
    /// </summary>
    public sealed class RankingStruct : BaseStruct<RankingStruct>
    {
        /// <summary>
        /// Backing field for the BestCheckpoints property.
        /// </summary>
        private XmlRpcArray<XmlRpcI4, int> bestCheckpoints = new XmlRpcArray<XmlRpcI4, int>();

        /// <summary>
        /// Backing field for the BestTime property.
        /// </summary>
        private XmlRpcI4 bestTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LadderScore property.
        /// </summary>
        private XmlRpcDouble ladderScore = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Backing field for the NbrLapsFinished property.
        /// </summary>
        private XmlRpcI4 nbrLapsFinished = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NickName property.
        /// </summary>
        private XmlRpcString nickName = new XmlRpcString();

        /// <summary>
        /// Backing field for the PlayerId property.
        /// </summary>
        private XmlRpcI4 playerId = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Rank property.
        /// </summary>
        private XmlRpcI4 rank = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Score property.
        /// </summary>
        private XmlRpcI4 score = new XmlRpcI4();

        /// <summary>
        /// Gets the checkpoint times of the player's best time in milliseconds.
        /// </summary>
        public IEnumerable<int> BestCheckpoints
        {
            get { return bestCheckpoints.Value.Select(xmlRpcI4 => xmlRpcI4.Value); }
        }

        /// <summary>
        /// Gets the player's best time in milliseconds.
        /// </summary>
        public int BestTime
        {
            get { return bestTime.Value; }
        }

        /// <summary>
        /// Gets the player's ladder score for the race.
        /// </summary>
        public double LadderScore
        {
            get { return ladderScore.Value; }
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
        /// Gets the player's rank.
        /// </summary>
        public int Rank
        {
            get { return rank.Value; }
        }

        /// <summary>
        /// Gets the players score.
        /// </summary>
        public int Score
        {
            get { return score.Value; }
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
                makeMemberElement("Rank", rank.GenerateXml()),
                makeMemberElement("BestTime", bestTime.GenerateXml()),
                makeMemberElement("BestCheckpoints", bestCheckpoints.GenerateXml()),
                makeMemberElement("Score", score.GenerateXml()),
                makeMemberElement("NbrLapsFinished", nbrLapsFinished.GenerateXml()),
                makeMemberElement("LadderScore", ladderScore.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override RankingStruct ParseXml(XElement xElement)
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

                    case "Rank":
                        rank.ParseXml(getValueContent(value, rank.ElementName));
                        break;

                    case "BestTime":
                        bestTime.ParseXml(getValueContent(value, bestTime.ElementName));
                        break;

                    case "BestCheckpoints":
                        bestCheckpoints.ParseXml(getValueContent(value, bestCheckpoints.ElementName));
                        break;

                    case "Score":
                        score.ParseXml(getValueContent(value, score.ElementName));
                        break;

                    case "NbrLapsFinished":
                        nbrLapsFinished.ParseXml(getValueContent(value, nbrLapsFinished.ElementName));
                        break;

                    case "LadderScore":
                        ladderScore.ParseXml(getValueContent(value, ladderScore.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}