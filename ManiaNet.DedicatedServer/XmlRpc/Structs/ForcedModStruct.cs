using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the structs that are part of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.ForcedModsStruct"/>
    /// and passed to the SetForcedMods method calls.
    /// </summary>
    public sealed class ForcedModStruct : BaseStruct<ForcedModStruct>
    {
        /// <summary>
        /// Backing field for the EnvName property.
        /// </summary>
        private XmlRpcString envName = new XmlRpcString();

        /// <summary>
        /// Backing field for the Url property.
        /// </summary>
        private XmlRpcString url = new XmlRpcString();

        /// <summary>
        /// Gets or sets the name of the environment that this mod is for.
        /// </summary>
        public string EnvName
        {
            get { return envName.Value; }
            set { envName.Value = value; }
        }

        /// <summary>
        /// Gets or sets the url of this mod.
        /// </summary>
        public string Url
        {
            get { return url.Value; }
            set { url.Value = value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("EnvName", envName.GenerateXml()),
                makeMemberElement("Url", url.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override ForcedModStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "EnvName":
                        envName.ParseXml(getValueContent(value, envName.ElementName));
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