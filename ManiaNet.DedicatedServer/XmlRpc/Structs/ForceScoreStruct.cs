using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    public sealed class ForceScoreStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the PlayerId property.
        /// </summary>
        private XmlRpcInt playerId = new XmlRpcInt();

        /// <summary>
        /// Backing field for the Score property.
        /// </summary>
        private XmlRpcInt score = new XmlRpcInt();

        /// <summary>
        /// Gets or sets the id of the player who's score is going to be forced.
        /// </summary>
        public int PlayerId
        {
            get { return playerId.Value; }
            set { playerId.Value = value; }
        }

        /// <summary>
        /// Gets or sets the number that the player's score is going to be set to.
        /// </summary>
        public int Score
        {
            get { return score.Value; }
            set { score.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.ForceScoreStruct"/> class with the given player id and score.
        /// </summary>
        /// <param name="playerId">The id of the player who's score is going to be forced.</param>
        /// <param name="score">Then number that the player's score is going to be set to.</param>
        public ForceScoreStruct(int playerId, int score)
        {
            PlayerId = playerId;
            Score = score;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.ForceScoreStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public ForceScoreStruct()
        { }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("PlayerId", playerId),
                makeMemberElement("Score", score));
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
                case "PlayerId":
                    if (!playerId.ParseXml(value))
                        return false;
                    break;

                case "Score":
                    if (!score.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}