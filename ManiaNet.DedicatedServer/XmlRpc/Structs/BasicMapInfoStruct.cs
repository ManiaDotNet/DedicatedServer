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
    /// Represents the structs returned by the GetMapList method call.
    /// </summary>
    public sealed class BasicMapInfoStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Author property.
        /// </summary>
        private readonly XmlRpcString author = new XmlRpcString();

        /// <summary>
        /// Backing field for the CopperPrice property.
        /// </summary>
        private readonly XmlRpcI4 copperPrice = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Environment property.
        /// </summary>
        private readonly XmlRpcString environment = new XmlRpcString();

        /// <summary>
        /// Backing field for the Filename property.
        /// </summary>
        private readonly XmlRpcString filename = new XmlRpcString();

        /// <summary>
        /// Backing field for the GoldTime property.
        /// </summary>
        private readonly XmlRpcI4 goldTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the MapStyle property.
        /// </summary>
        private readonly XmlRpcString mapStyle = new XmlRpcString();

        /// <summary>
        /// Backing field for the MapType property.
        /// </summary>
        private readonly XmlRpcString mapType = new XmlRpcString();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private readonly XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the UId property.
        /// </summary>
        private readonly XmlRpcString uId = new XmlRpcString();

        /// <summary>
        /// Gets the login of the map's author.
        /// </summary>
        public string Author
        {
            get { return author.Value; }
        }

        /// <summary>
        /// Gets the map's cost in coppers.
        /// </summary>
        public int CopperPrice
        {
            get { return copperPrice.Value; }
        }

        /// <summary>
        /// Gets the map's environment.
        /// </summary>
        public string Environment
        {
            get { return environment.Value; }
        }

        /// <summary>
        /// Gets the path to the map's file, relative to UserData/Maps/
        /// </summary>
        public string Filename
        {
            get { return filename.Value; }
        }

        /// <summary>
        /// Gets the map's Gold medal time in milliseconds.
        /// </summary>
        public int GoldTime
        {
            get { return goldTime.Value; }
        }

        /// <summary>
        /// Gets the map's style.
        /// </summary>
        public string MapStyle
        {
            get { return mapStyle.Value; }
        }

        /// <summary>
        /// Gets the map's display name.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
        }

        /// <summary>
        /// Gets the map's unique identifier.
        /// </summary>
        public string UId
        {
            get { return uId.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Name", name),
                makeMemberElement("UId", uId),
                makeMemberElement("Filename", filename),
                makeMemberElement("Environnement", environment), // [sic]
                makeMemberElement("Author", author),
                makeMemberElement("GoldTime", goldTime),
                makeMemberElement("CopperPrice", copperPrice),
                makeMemberElement("MapType", mapType),
                makeMemberElement("MapStyle", mapStyle));
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

                case "UId":
                    if (!uId.ParseXml(value))
                        return false;
                    break;

                case "Filename":
                    if (!filename.ParseXml(value))
                        return false;
                    break;

                case "Environnement": // [sic]
                    if (!environment.ParseXml(value))
                        return false;
                    break;

                case "Author":
                    if (!author.ParseXml(value))
                        return false;
                    break;

                case "GoldTime":
                    if (!goldTime.ParseXml(value))
                        return false;
                    break;

                case "CopperPrice":
                    if (!copperPrice.ParseXml(value))
                        return false;
                    break;

                case "MapType":
                    if (!mapType.ParseXml(value))
                        return false;
                    break;

                case "MapStyle":
                    if (!mapStyle.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}