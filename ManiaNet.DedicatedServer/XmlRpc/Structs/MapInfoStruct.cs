using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetCurrentMapInfo, GetNextMapInfo, and GetMapInfo method calls.
    /// </summary>
    public sealed class MapInfoStruct : BaseStruct<MapInfoStruct>
    {
        /// <summary>
        /// Backing field for the Author property.
        /// </summary>
        private XmlRpcString author = new XmlRpcString();

        /// <summary>
        /// Backing field for the AuthorTime property.
        /// </summary>
        private XmlRpcI4 authorTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the BronzeTime property.
        /// </summary>
        private XmlRpcI4 bronzeTime = new XmlRpcI4();

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
        /// Backing field for the LapRace property.
        /// </summary>
        private XmlRpcBoolean lapRace = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the MapStyle property.
        /// </summary>
        private XmlRpcString mapStyle = new XmlRpcString();

        /// <summary>
        /// Backing field for the MapType property.
        /// </summary>
        private XmlRpcString mapType = new XmlRpcString();

        /// <summary>
        /// Backing field for the Mood property.
        /// </summary>
        private XmlRpcString mood = new XmlRpcString();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the NbCheckpoints property.
        /// </summary>
        private XmlRpcI4 nbCheckpoints = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NbLaps property.
        /// </summary>
        private XmlRpcI4 nbLaps = new XmlRpcI4();

        /// <summary>
        /// Backing field for the SilverTime property.
        /// </summary>
        private XmlRpcI4 silverTime = new XmlRpcI4();

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
        /// Gets the map's author's time in milliseconds.
        /// </summary>
        public int AuthorTime
        {
            get { return authorTime.Value; }
        }

        /// <summary>
        /// Gets the map's Bronze medal time in milliseconds.
        /// </summary>
        public int BronzeTime
        {
            get { return bronzeTime.Value; }
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
        /// Gets whether the map is a lap race or not.
        /// </summary>
        public bool LapRace
        {
            get { return lapRace.Value; }
        }

        /// <summary>
        /// Gets the map's style.
        /// </summary>
        public string MapStyle
        {
            get { return mapStyle.Value; }
        }

        /// <summary>
        /// Gets the map's mood (time of day).
        /// </summary>
        public string Mood
        {
            get { return mood.Value; }
        }

        /// <summary>
        /// Gets the map's display name.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
        }

        /// <summary>
        /// Gets the number of checkpoints on the map. -1 when gotten from the GetNextMapInfo or GetMapInfo method calls.
        /// </summary>
        public int NbCheckpoints
        {
            get { return nbCheckpoints.Value; }
        }

        /// <summary>
        /// Gets the number of laps players would have to drive on the map. 0 if it's not in laps mode. -1 when gotten from the GetNextMapInfo or GetMapInfo method calls.
        /// </summary>
        public int NbLaps
        {
            get { return nbLaps.Value; }
        }

        /// <summary>
        /// Gets the maps Silver medal time in milliseconds.
        /// </summary>
        public int SilverTime
        {
            get { return silverTime.Value; }
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
                makeMemberElement("UId", uId.GenerateXml()),
                makeMemberElement("Name", name.GenerateXml()),
                makeMemberElement("Filename", filename.GenerateXml()),
                makeMemberElement("Author", author.GenerateXml()),
                makeMemberElement("Environnement", environment.GenerateXml()), // [sic]
                makeMemberElement("Mood", mood.GenerateXml()),
                makeMemberElement("BronzeTime", bronzeTime.GenerateXml()),
                makeMemberElement("SilverTime", silverTime.GenerateXml()),
                makeMemberElement("GoldTime", goldTime.GenerateXml()),
                makeMemberElement("AuthorTime", authorTime.GenerateXml()),
                makeMemberElement("CopperPrice", copperPrice.GenerateXml()),
                makeMemberElement("LapRace", lapRace.GenerateXml()),
                makeMemberElement("NbLaps", nbLaps.GenerateXml()),
                makeMemberElement("NbCheckpoints", nbCheckpoints.GenerateXml()),
                makeMemberElement("MapType", mapType.GenerateXml()),
                makeMemberElement("MapStyle", mapStyle.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override MapInfoStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "UId":
                        uId.ParseXml(getValueContent(value, uId.ElementName));
                        break;

                    case "Name":
                        name.ParseXml(getValueContent(value, name.ElementName));
                        break;

                    case "Filename":
                        filename.ParseXml(getValueContent(value, filename.ElementName));
                        break;

                    case "Author":
                        author.ParseXml(getValueContent(value, author.ElementName));
                        break;

                    case "Environnement": // [sic]
                        environment.ParseXml(getValueContent(value, environment.ElementName));
                        break;

                    case "Mood":
                        mood.ParseXml(getValueContent(value, mood.ElementName));
                        break;

                    case "BronzeTime":
                        bronzeTime.ParseXml(getValueContent(value, bronzeTime.ElementName));
                        break;

                    case "SilverTime":
                        silverTime.ParseXml(getValueContent(value, silverTime.ElementName));
                        break;

                    case "GoldTime":
                        goldTime.ParseXml(getValueContent(value, goldTime.ElementName));
                        break;

                    case "AuthorTime":
                        authorTime.ParseXml(getValueContent(value, authorTime.ElementName));
                        break;

                    case "CopperPrice":
                        copperPrice.ParseXml(getValueContent(value, copperPrice.ElementName));
                        break;

                    case "NbLaps":
                        nbLaps.ParseXml(getValueContent(value, nbLaps.ElementName));
                        break;

                    case "NbCheckpoints":
                        nbCheckpoints.ParseXml(getValueContent(value, nbCheckpoints.ElementName));
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