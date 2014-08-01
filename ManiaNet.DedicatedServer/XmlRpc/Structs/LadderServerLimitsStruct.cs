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
    /// Represents the struct returned by the GetLadderServerLimits method call.
    /// </summary>
    public sealed class LadderServerLimitsStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the LadderServerLimitMax property.
        /// </summary>
        private readonly XmlRpcDouble ladderServerLimitMax = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the LadderServerLimitMin property.
        /// </summary>
        private readonly XmlRpcDouble ladderServerLimitMin = new XmlRpcDouble();

        /// <summary>
        /// Gets the maximum number of ladder points a player can reach on the server.
        /// </summary>
        public double LadderServerLimitMax
        {
            get { return ladderServerLimitMax.Value; }
        }

        /// <summary>
        /// Gets the minimumm number of ladder points a player has to have to join the server.
        /// </summary>
        public double LadderServerLimitMin
        {
            get { return ladderServerLimitMin.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("LadderServerLimitMin", ladderServerLimitMin),
                makeMemberElement("LadderServerLimitMax", ladderServerLimitMax));
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
                case "LadderServerLimitMin":
                    if (!ladderServerLimitMin.ParseXml(value))
                        return false;
                    break;

                case "LadderServerLimitMax":
                    if (!ladderServerLimitMax.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}