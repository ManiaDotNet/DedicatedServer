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
    /// Represents the struct returned by the GetForcedMusic method call.
    /// </summary>
    public sealed class ForcedMusicStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Override property.
        /// </summary>
        private readonly XmlRpcBoolean @override = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the File property.
        /// </summary>
        private readonly XmlRpcString file = new XmlRpcString();

        /// <summary>
        /// Backing field for the Url property.
        /// </summary>
        private readonly XmlRpcString url = new XmlRpcString();

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
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Override", @override),
                makeMemberElement("Url", url),
                makeMemberElement("File", file));
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
                case "Override":
                    if (!@override.ParseXml(value))
                        return false;
                    break;

                case "Url":
                    if (!url.ParseXml(value))
                        return false;
                    break;

                case "File":
                    if (!file.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}