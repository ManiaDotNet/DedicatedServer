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
    /// Represents the structs that are returned from the GetForcedSkins and passed to the SetForcedSkins method calls.
    /// </summary>
    public sealed class ForcedSkinStruct : BaseStruct
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.ForcedSkinStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public ForcedSkinStruct()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.ForcedSkinStruct"/> class
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
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Orig", orig),
                makeMemberElement("Name", name),
                makeMemberElement("Checksum", checksum),
                makeMemberElement("Url", url));
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
                case "Orig":
                    if (!orig.ParseXml(value))
                        return false;
                    break;

                case "Name":
                    if (!name.ParseXml(value))
                        return false;
                    break;

                case "Checksum":
                    if (!checksum.ParseXml(value))
                        return false;
                    break;

                case "Url":
                    if (!url.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}