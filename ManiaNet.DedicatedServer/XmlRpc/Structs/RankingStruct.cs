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
    /// Represents the structs returned by the GetCurrentRanking and GetCurrentRankingForLogin method calls.
    /// </summary>
    public sealed class RankingStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the BestCheckpoints property.
        /// </summary>
        private readonly XmlRpcArray<XmlRpcI4, int> bestCheckpoints = new XmlRpcArray<XmlRpcI4, int>();

        /// <summary>
        /// Backing field for the BestTime property.
        /// </summary>
        private readonly XmlRpcI4 bestTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LadderScore property.
        /// </summary>
        private readonly XmlRpcDouble ladderScore = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private readonly XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Backing field for the NbrLapsFinished property.
        /// </summary>
        private readonly XmlRpcI4 nbrLapsFinished = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NickName property.
        /// </summary>
        private readonly XmlRpcString nickName = new XmlRpcString();

        /// <summary>
        /// Backing field for the PlayerId property.
        /// </summary>
        private readonly XmlRpcI4 playerId = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Rank property.
        /// </summary>
        private readonly XmlRpcI4 rank = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Score property.
        /// </summary>
        private readonly XmlRpcI4 score = new XmlRpcI4();

        /// <summary>
        /// Gets the checkpoint times of the player's best time in milliseconds.
        /// Only in legacy modes.
        /// </summary>
        [NotNull, UsedImplicitly]
        public IEnumerable<int> BestCheckpoints
        {
            get { return bestCheckpoints.Value.Select(xmlRpcI4 => xmlRpcI4.Value); }
        }

        /// <summary>
        /// Gets the player's best time in milliseconds.
        /// Only in legacy modes.
        /// </summary>
        [UsedImplicitly]
        public int BestTime
        {
            get { return bestTime.Value; }
        }

        /// <summary>
        /// Gets the player's ladder score for the race.
        /// Only in legacy modes.
        /// </summary>
        [UsedImplicitly]
        public double LadderScore
        {
            get { return ladderScore.Value; }
        }

        /// <summary>
        /// Gets the player's login.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return login.Value; }
        }

        /// <summary>
        /// Gets the number of laps that the player finished.
        /// Only in legacy modes.
        /// </summary>
        [UsedImplicitly]
        public int NbrLapsFinished
        {
            get { return nbrLapsFinished.Value; }
        }

        /// <summary>
        /// Gets the player's nickname.
        /// </summary>
        [UsedImplicitly]
        public string NickName
        {
            get { return nickName.Value; }
        }

        /// <summary>
        /// Gets the player's id for the current session.
        /// </summary>
        [UsedImplicitly]
        public int PlayerId
        {
            get { return playerId.Value; }
        }

        /// <summary>
        /// Gets the player's rank.
        /// </summary>
        [UsedImplicitly]
        public int Rank
        {
            get { return rank.Value; }
        }

        /// <summary>
        /// Gets the players score.
        /// Only in legacy modes.
        /// </summary>
        [UsedImplicitly]
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
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Login", login),
                makeMemberElement("NickName", nickName),
                makeMemberElement("PlayerId", playerId),
                makeMemberElement("Rank", rank),
                makeMemberElement("BestTime", bestTime),
                makeMemberElement("BestCheckpoints", bestCheckpoints),
                makeMemberElement("Score", score),
                makeMemberElement("NbrLapsFinished", nbrLapsFinished),
                makeMemberElement("LadderScore", ladderScore));
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

                case "Rank":
                    if (!rank.ParseXml(value))
                        return false;
                    break;

                case "BestTime":
                    if (!bestTime.ParseXml(value))
                        return false;
                    break;

                case "BestCheckpoints":
                    if (!bestCheckpoints.ParseXml(value))
                        return false;
                    break;

                case "Score":
                    if (!score.ParseXml(value))
                        return false;
                    break;

                case "NbrLapsFinished":
                    if (!nbrLapsFinished.ParseXml(value))
                        return false;
                    break;

                case "LadderScore":
                    if (!ladderScore.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}