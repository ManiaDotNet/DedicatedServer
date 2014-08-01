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
    /// Represents the struct returned from the GetTeamInfo method call.
    /// </summary>
    public sealed class TeamInfoStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the City property.
        /// </summary>
        private readonly XmlRpcString city = new XmlRpcString();

        /// <summary>
        /// Backing field for the ClubLinkUrl property.
        /// </summary>
        private readonly XmlRpcString clubLinkUrl = new XmlRpcString();

        /// <summary>
        /// Backing field for the EmblemUrl property.
        /// </summary>
        private readonly XmlRpcString emblemUrl = new XmlRpcString();

        /// <summary>
        /// Backing field for the HuePrimary property.
        /// </summary>
        private readonly XmlRpcDouble huePrimary = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the HueSecondary property.
        /// </summary>
        private readonly XmlRpcDouble hueSecondary = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private readonly XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the Rgb property.
        /// </summary>
        private readonly XmlRpcString rgb = new XmlRpcString();

        /// <summary>
        /// Backing field for the ZonePath property.
        /// </summary>
        private readonly XmlRpcString zonePath = new XmlRpcString();

        /// <summary>
        /// Gets the name of the City that the team is from.
        /// </summary>
        public string City
        {
            get { return city.Value; }
        }

        /// <summary>
        /// Gets the club link url of the team.
        /// </summary>
        public string ClubLinkUrl
        {
            get { return clubLinkUrl.Value; }
        }

        /// <summary>
        /// Gets the URL of the Emblem of the team.
        /// </summary>
        public string EmblemUrl
        {
            get { return emblemUrl.Value; }
        }

        /// <summary>
        /// Gets the primary hue of the team.
        /// </summary>
        public double HuePrimary
        {
            get { return huePrimary.Value; }
        }

        /// <summary>
        /// Gets the secondary hue of the team.
        /// </summary>
        public double HueSecondary
        {
            get { return hueSecondary.Value; }
        }

        /// <summary>
        /// Gets the name of the team.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
        }

        /// <summary>
        /// Gets the three letter RGB of the team's color.
        /// </summary>
        public string Rgb
        {
            get { return rgb.Value; }
        }

        /// <summary>
        /// Gets the ZonePath of the team.
        /// </summary>
        public string ZonePath
        {
            get { return zonePath.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Name", name),
                makeMemberElement("ZonePath", zonePath),
                makeMemberElement("City", city),
                makeMemberElement("EmblemUrl", emblemUrl),
                makeMemberElement("ClubLinkUrl", clubLinkUrl),
                makeMemberElement("HuePrimary", huePrimary),
                makeMemberElement("HueSecondary", hueSecondary),
                makeMemberElement("RGB", rgb));
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
                case "Name":
                    if (!name.ParseXml(value))
                        return false;
                    break;

                case "ZonePath":
                    if (!zonePath.ParseXml(value))
                        return false;
                    break;

                case "City":
                    if (!city.ParseXml(value))
                        return false;
                    break;

                case "EmblemUrl":
                    if (!emblemUrl.ParseXml(value))
                        return false;
                    break;

                case "ClubLinkUrl":
                    if (!clubLinkUrl.ParseXml(value))
                        return false;
                    break;

                case "HuePrimary":
                    if (!huePrimary.ParseXml(value))
                        return false;
                    break;

                case "HueSecondary":
                    if (!hueSecondary.ParseXml(value))
                        return false;
                    break;

                case "RGB":
                    if (!rgb.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}