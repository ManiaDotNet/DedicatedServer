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
    /// Represents the struct returned by the GetForcedClubLinks method call.
    /// </summary>
    public sealed class ForcedClubLinksStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the ClubLink1 property.
        /// </summary>
        private readonly XmlRpcString clubLink1 = new XmlRpcString();

        /// <summary>
        /// Backing field for the ClubLink2 property.
        /// </summary>
        private readonly XmlRpcString clubLink2 = new XmlRpcString();

        /// <summary>
        /// Gets the forced club link for team 1.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ClubLink1
        {
            get { return clubLink1.Value; }
        }

        /// <summary>
        /// Gets the forced club link for team 2.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ClubLink2
        {
            get { return clubLink2.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("ClubLink1", clubLink1),
                makeMemberElement("ClubLink2", clubLink2));
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
                case "ClubLink1":
                    if (!clubLink1.ParseXml(value))
                        return false;
                    break;

                case "ClubLink2":
                    if (!clubLink2.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}