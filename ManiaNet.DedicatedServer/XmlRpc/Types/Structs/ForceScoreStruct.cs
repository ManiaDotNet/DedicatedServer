using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    public sealed class ForceScoreStruct : BaseStruct<ForceScoreStruct>
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Types.Structs.ForceScoreStruct"/> class with the given player id and score.
        /// </summary>
        /// <param name="playerId">The id of the player who's score is going to be forced.</param>
        /// <param name="score">Then number that the player's score is going to be set to.</param>
        public ForceScoreStruct(int playerId, int score)
        {
            PlayerId = playerId;
            Score = score;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Types.Structs.ForceScoreStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public ForceScoreStruct()
        { }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("PlayerId", playerId.GenerateXml()),
                makeMemberElement("Score", score.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override ForceScoreStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "PlayerId":
                        playerId.ParseXml(getValueContent(value, playerId.ElementName));
                        break;

                    case "Score":
                        score.ParseXml(getValueContent(value, score.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}