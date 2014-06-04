using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the structs returned by the GetMapList method call.
    /// </summary>
    public sealed class BasicMapInfoStruct : BaseStruct<BasicMapInfoStruct>
    {
        /// <summary>
        /// Backing field for the Author property.
        /// </summary>
        private XmlRpcString author = new XmlRpcString();

        /// <summary>
        /// Backing field for the CopperPrice property.
        /// </summary>
        private XmlRpcI4 copperPrice = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Environment property.
        /// </summary>
        private XmlRpcString environment = new XmlRpcString();

        /// <summary>
        /// Backing field for the Filename property.
        /// </summary>
        private XmlRpcString filename = new XmlRpcString();

        /// <summary>
        /// Backing field for the GoldTime property.
        /// </summary>
        private XmlRpcI4 goldTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the MapStyle property.
        /// </summary>
        private XmlRpcString mapStyle = new XmlRpcString();

        /// <summary>
        /// Backing field for the MapType property.
        /// </summary>
        private XmlRpcString mapType = new XmlRpcString();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the UId property.
        /// </summary>
        private XmlRpcString uId = new XmlRpcString();

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
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Name", name.GenerateXml()),
                makeMemberElement("UId", uId.GenerateXml()),
                makeMemberElement("Filename", filename.GenerateXml()),
                makeMemberElement("Environnement", environment.GenerateXml()), // [sic]
                makeMemberElement("Author", author.GenerateXml()),
                makeMemberElement("GoldTime", goldTime.GenerateXml()),
                makeMemberElement("CopperPrice", copperPrice.GenerateXml()),
                makeMemberElement("MapType", mapType.GenerateXml()),
                makeMemberElement("MapStyle", mapStyle.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override BasicMapInfoStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Name":
                        name.ParseXml(getValueContent(value, name.ElementName));
                        break;

                    case "UId":
                        uId.ParseXml(getValueContent(value, uId.ElementName));
                        break;

                    case "Filename":
                        filename.ParseXml(getValueContent(value, filename.ElementName));
                        break;

                    case "Environnement": // [sic]
                        environment.ParseXml(getValueContent(value, environment.ElementName));
                        break;

                    case "Author":
                        author.ParseXml(getValueContent(value, author.ElementName));
                        break;

                    case "GoldTime":
                        goldTime.ParseXml(getValueContent(value, goldTime.ElementName));
                        break;

                    case "CopperPrice":
                        copperPrice.ParseXml(getValueContent(value, copperPrice.ElementName));
                        break;

                    case "MapType":
                        mapType.ParseXml(getValueContent(value, mapType.ElementName));
                        break;

                    case "MapStyle":
                        mapStyle.ParseXml(getValueContent(value, mapStyle.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}