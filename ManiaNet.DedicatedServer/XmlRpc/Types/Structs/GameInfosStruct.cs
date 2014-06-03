using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetGameInfos method call.
    /// </summary>
    public sealed class GameInfosStruct : BaseStruct<GameInfosStruct>
    {
        /// <summary>
        /// Backing field for the CurrentGameInfos property.
        /// </summary>
        private XmlRpcStruct<ReturnedGameInfosStruct> currentGameInfos = new XmlRpcStruct<ReturnedGameInfosStruct>();

        /// <summary>
        /// Backing field for the NextGameInfos property.
        /// </summary>
        private XmlRpcStruct<ReturnedGameInfosStruct> nextGameInfos = new XmlRpcStruct<ReturnedGameInfosStruct>();

        /// <summary>
        /// Gets the current game infos.
        /// </summary>
        public ReturnedGameInfosStruct CurrentGameInfos
        {
            get { return currentGameInfos.Value; }
        }

        /// <summary>
        /// Gets the next game infos.
        /// </summary>
        public ReturnedGameInfosStruct NextGameInfos
        {
            get { return nextGameInfos.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("CurrentGameInfos", CurrentGameInfos.GenerateXml()),
                makeMemberElement("NextGameInfos", NextGameInfos.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override GameInfosStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "CurrentGameInfos":
                        CurrentGameInfos.ParseXml(getValueContent(value, currentGameInfos.ElementName));
                        break;

                    case "NextGameInfos":
                        NextGameInfos.ParseXml(getValueContent(value, nextGameInfos.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}