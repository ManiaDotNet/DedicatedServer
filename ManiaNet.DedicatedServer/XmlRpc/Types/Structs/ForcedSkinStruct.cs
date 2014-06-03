using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the structs that are returned from the GetForcedSkins and passed to the SetForcedSkins method calls.
    /// </summary>
    public sealed class ForcedSkinStruct : BaseStruct<ForcedSkinStruct>
    {
        /// <summary>
        /// Backing field for the Checksum property.
        /// </summary>
        private XmlRpcString checksum = new XmlRpcString();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the Orig property.
        /// </summary>
        private XmlRpcString orig = new XmlRpcString();

        /// <summary>
        /// Backing field for the Url property.
        /// </summary>
        private XmlRpcString url = new XmlRpcString();

        /// <summary>
        /// Gets or sets the checksum of the skin.
        /// </summary>
        public string Checksum
        {
            get { return checksum.Value; }
            set { checksum.Value = value; }
        }

        /// <summary>
        /// Gets or sets the name of the skin.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
            set { name.Value = value; }
        }

        /// <summary>
        /// Gets or sets the name of the original skin. * for all.
        /// </summary>
        public string Orig
        {
            get { return orig.Value; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new FormatException("Name of the original skin can't be empty. Use * for all.");

                orig.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the url of the skin.
        /// </summary>
        public string Url
        {
            get { return url.Value; }
            set { url.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Types.Structs.ForcedSkinStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public ForcedSkinStruct()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Types.Structs.ForcedSkinStruct"/> class
        /// with the given name for the orignal skin and optional identifiers for the replacement.
        /// Not all identifiers are required.
        /// <para/>
        /// If all optional parameters are left empty, it means that the original skin won't be affected.
        /// </summary>
        /// <param name="orig">The name of the original skin.</param>
        /// <param name="name">The name of the replacement skin.</param>
        /// <param name="checksum">The checksum of the replacement skin.</param>
        /// <param name="url">The url of the replacement skin.</param>
        public ForcedSkinStruct(string orig, string name = "", string checksum = "", string url = "")
        {
            Orig = orig;
            Name = name;
            Checksum = checksum;
            Url = url;
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Orig", orig.GenerateXml()),
                makeMemberElement("Name", name.GenerateXml()),
                makeMemberElement("Checksum", checksum.GenerateXml()),
                makeMemberElement("Url", url.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override ForcedSkinStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Orig":
                        orig.ParseXml(getValueContent(value, orig.ElementName));
                        break;

                    case "Name":
                        name.ParseXml(getValueContent(value, name.ElementName));
                        break;

                    case "Checksum":
                        checksum.ParseXml(getValueContent(value, checksum.ElementName));
                        break;

                    case "Url":
                        url.ParseXml(getValueContent(value, url.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}