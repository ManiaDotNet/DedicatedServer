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
    /// Represents the struct returned by the GetVersion method call.
    /// </summary>
    public sealed class ApplicationVersionStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the ApiVersion property.
        /// </summary>
        private readonly XmlRpcString apiVersion = new XmlRpcString();

        /// <summary>
        /// Backing field for the Build property.
        /// </summary>
        private readonly XmlRpcString build = new XmlRpcString();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private readonly XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the TitleId property.
        /// </summary>
        private readonly XmlRpcString titleId = new XmlRpcString();

        /// <summary>
        /// Backing field for the Version property.
        /// </summary>
        private readonly XmlRpcString version = new XmlRpcString();

        /// <summary>
        /// Gets the Version of the API used for callbacks.
        /// </summary>
        public string ApiVersion
        {
            get { return apiVersion.Value; }
        }

        /// <summary>
        /// Gets the Build of the server application.
        /// </summary>
        public string Build
        {
            get { return build.Value; }
        }

        /// <summary>
        /// Gets the Name of the server application.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
        }

        /// <summary>
        /// Gets the ID of the Title that's currently being played (TMCanyon, TMValley, etc.) on the server application.
        /// </summary>
        public string TitleId
        {
            get { return titleId.Value; }
        }

        /// <summary>
        /// Gets the Version of the server application.
        /// </summary>
        public string Version
        {
            get { return version.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Name", name),
                makeMemberElement("TitleId", titleId),
                makeMemberElement("Version", version),
                makeMemberElement("Build", build),
                makeMemberElement("ApiVersion", apiVersion));
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

                case "TitleId":
                    if (!titleId.ParseXml(value))
                        return false;
                    break;

                case "Version":
                    if (!version.ParseXml(value))
                        return false;
                    break;

                case "Build":
                    if (!build.ParseXml(value))
                        return false;
                    break;

                case "ApiVersion":
                    if (!apiVersion.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}