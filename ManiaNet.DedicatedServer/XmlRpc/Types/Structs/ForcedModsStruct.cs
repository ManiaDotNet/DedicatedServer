using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetForcedMods method call.
    /// </summary>
    public sealed class ForcedModsStruct : BaseStruct<ForcedModsStruct>
    {
        /// <summary>
        /// Backing field for the Override property.
        /// </summary>
        private XmlRpcBoolean @override = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the Mods property.
        /// </summary>
        private XmlRpcArray<XmlRpcStruct<ForcedModStruct>, ForcedModStruct> mods = new XmlRpcArray<XmlRpcStruct<ForcedModStruct>, ForcedModStruct>();

        /// <summary>
        /// Gets the forced mods.
        /// </summary>
        public IEnumerable<ForcedModStruct> Mods
        {
            get { return mods.Value.Select(xmlRpcStruct => xmlRpcStruct.Value); }
        }

        /// <summary>
        /// Gets whether the mods override those in challenges that already have one or not.
        /// </summary>
        public bool Override
        {
            get { return @override.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Override", @override.GenerateXml()),
                makeMemberElement("Mods", mods.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override ForcedModsStruct ParseXml(XElement xElement)
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

                    case "Mods":
                        mods.ParseXml(getValueContent(value, mods.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}