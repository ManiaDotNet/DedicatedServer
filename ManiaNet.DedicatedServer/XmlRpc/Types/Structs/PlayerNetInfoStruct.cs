using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the structs returned from the GetNetworkStats method call in the PlayerNetInfos array.
    /// </summary>
    public sealed class PlayerNetInfoStruct : BaseStruct<PlayerNetInfoStruct>
    {
        /// <summary>
        /// Backing field for the IPAddress property.
        /// </summary>
        private XmlRpcString ipAddress = new XmlRpcString();

        /// <summary>
        /// Backing field for the LatestNetworkActivity property.
        /// </summary>
        private XmlRpcI4 latestNetworkActivity = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Backing field for the NetworkLossRate property.
        /// </summary>
        private XmlRpcDouble networkLossRate = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the StateUpdateLatency property.
        /// </summary>
        private XmlRpcI4 stateUpdateLatency = new XmlRpcI4();

        /// <summary>
        /// Backing field for the StateUpdatePeriod property.
        /// </summary>
        private XmlRpcI4 stateUpdatePeriod = new XmlRpcI4();

        /// <summary>
        /// Gets the player's IP address, including the port.
        /// </summary>
        public string IPAddress
        {
            get { return ipAddress.Value; }
        }

        /// <summary>
        /// Gets the time in milliseconds since the player's last network activity.
        /// </summary>
        public int LatestNetworkActivity
        {
            get { return latestNetworkActivity.Value; }
        }

        /// <summary>
        /// Gets the player's login.
        /// </summary>
        public string Login
        {
            get { return login.Value; }
        }

        /// <summary>
        /// Gets the rate at which the player's packets get lost.
        /// </summary>
        public double NetworkLossRate
        {
            get { return networkLossRate.Value; }
        }

        /// <summary>
        /// Gets the player's state update latency in milliseconds.
        /// </summary>
        public int StateUpdateLatency
        {
            get { return stateUpdateLatency.Value; }
        }

        /// <summary>
        /// Gets the player's state update period in milliseconds.
        /// </summary>
        public int StateUpdatePeriod
        {
            get { return stateUpdateLatency.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Login", login.GenerateXml()),
                makeMemberElement("IPAddress", ipAddress.GenerateXml()),
                makeMemberElement("StateUpdateLatency", stateUpdateLatency.GenerateXml()),
                makeMemberElement("StateUpdatePeriod", stateUpdatePeriod.GenerateXml()),
                makeMemberElement("LatestNetworkActivity", latestNetworkActivity.GenerateXml()),
                makeMemberElement("NetworkLossRate", networkLossRate.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override PlayerNetInfoStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Login":
                        login.ParseXml(getValueContent(value, login.ElementName));
                        break;

                    case "IPAddress":
                        ipAddress.ParseXml(getValueContent(value, ipAddress.ElementName));
                        break;

                    case "StateUpdateLatency":
                        stateUpdateLatency.ParseXml(getValueContent(value, stateUpdateLatency.ElementName));
                        break;

                    case "StateUpdatePeriod":
                        stateUpdatePeriod.ParseXml(getValueContent(value, stateUpdatePeriod.ElementName));
                        break;

                    case "LatestNetworkActivity":
                        latestNetworkActivity.ParseXml(getValueContent(value, latestNetworkActivity.ElementName));
                        break;

                    case "NetworkLossRate":
                        networkLossRate.ParseXml(getValueContent(value, networkLossRate.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}