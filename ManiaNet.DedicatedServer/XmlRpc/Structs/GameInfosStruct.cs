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
    /// Represents the struct returned by the GetGameInfos method call.
    /// </summary>
    public sealed class GameInfosStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the CurrentGameInfos property.
        /// </summary>
        private readonly XmlRpcStruct<ReturnedGameInfosStruct> currentGameInfos = new XmlRpcStruct<ReturnedGameInfosStruct>();

        /// <summary>
        /// Backing field for the NextGameInfos property.
        /// </summary>
        private readonly XmlRpcStruct<ReturnedGameInfosStruct> nextGameInfos = new XmlRpcStruct<ReturnedGameInfosStruct>();

        /// <summary>
        /// Gets the current game infos.
        /// </summary>
        [NotNull, UsedImplicitly]
        public ReturnedGameInfosStruct CurrentGameInfos
        {
            get { return currentGameInfos.Value; }
        }

        /// <summary>
        /// Gets the next game infos.
        /// </summary>
        [NotNull, UsedImplicitly]
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
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("CurrentGameInfos", currentGameInfos),
                makeMemberElement("NextGameInfos", nextGameInfos));
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
                case "CurrentGameInfos":
                    if (!currentGameInfos.ParseXml(value))
                        return false;
                    break;

                case "NextGameInfos":
                    if (!nextGameInfos.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}