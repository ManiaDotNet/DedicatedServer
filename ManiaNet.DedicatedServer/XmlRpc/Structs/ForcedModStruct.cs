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
    /// Represents the structs that are part of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.ForcedModsStruct"/>
    /// and passed to the SetForcedMods method call.
    /// </summary>
    public sealed class ForcedModStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the EnvName property.
        /// </summary>
        private readonly XmlRpcString envName = new XmlRpcString();

        /// <summary>
        /// Backing field for the Url property.
        /// </summary>
        private readonly XmlRpcString url = new XmlRpcString();

        /// <summary>
        /// Gets or sets the name of the environment that this mod is for.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string EnvName
        {
            get { return envName.Value; }
            set { envName.Value = value; }
        }

        /// <summary>
        /// Gets or sets the url of this mod.
        /// </summary>
        [NotNull, UsedImplicitly]
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
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("EnvName", envName),
                makeMemberElement("Url", url));
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
                case "EnvName":
                    if (!envName.ParseXml(value))
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