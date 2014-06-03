using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetForcedMusic method call.
    /// </summary>
    public sealed class ForcedMusicStruct : BaseStruct<ForcedMusicStruct>
    {
        /// <summary>
        /// Backing field for the Override property.
        /// </summary>
        private XmlRpcBoolean @override = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the File property.
        /// </summary>
        private XmlRpcString file = new XmlRpcString();

        /// <summary>
        /// Backing field for the Url property.
        /// </summary>
        private XmlRpcString url = new XmlRpcString();

        /// <summary>
        /// Gets the path to the music file.
        /// </summary>
        public string File
        {
            get { return file.Value; }
        }

        /// <summary>
        /// Gets whether the music overrides those in challenges that already have one.
        /// </summary>
        public bool Override
        {
            get { return @override.Value; }
        }

        /// <summary>
        /// Gets the url of the music file.
        /// </summary>
        public string Url
        {
            get { return url.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Override", @override.GenerateXml()),
                makeMemberElement("Url", url.GenerateXml()),
                makeMemberElement("File", file.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override ForcedMusicStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Override":
                        @override.ParseXml(getValueContent(value, @override.ElementName));
                        break;

                    case "Url":
                        url.ParseXml(getValueContent(value, url.ElementName));
                        break;

                    case "File":
                        file.ParseXml(getValueContent(value, file.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}