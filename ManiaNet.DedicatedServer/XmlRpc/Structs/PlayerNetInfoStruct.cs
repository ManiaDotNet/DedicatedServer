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
    /// Represents the structs returned from the GetNetworkStats method call in the PlayerNetInfos array.
    /// </summary>
    public sealed class PlayerNetInfoStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the IPAddress property.
        /// </summary>
        private readonly XmlRpcString ipAddress = new XmlRpcString();

        /// <summary>
        /// Backing field for the LatestNetworkActivity property.
        /// </summary>
        private readonly XmlRpcI4 latestNetworkActivity = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Login property.
        /// </summary>
        private readonly XmlRpcString login = new XmlRpcString();

        /// <summary>
        /// Backing field for the NetworkLossRate property.
        /// </summary>
        private readonly XmlRpcDouble networkLossRate = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the StateUpdateLatency property.
        /// </summary>
        private readonly XmlRpcI4 stateUpdateLatency = new XmlRpcI4();

        /// <summary>
        /// Backing field for the StateUpdatePeriod property.
        /// </summary>
        private readonly XmlRpcI4 stateUpdatePeriod = new XmlRpcI4();

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
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Login", login),
                makeMemberElement("IPAddress", ipAddress),
                makeMemberElement("StateUpdateLatency", stateUpdateLatency),
                makeMemberElement("StateUpdatePeriod", stateUpdatePeriod),
                makeMemberElement("LatestNetworkActivity", latestNetworkActivity),
                makeMemberElement("NetworkLossRate", networkLossRate));
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
                case "Login":
                    if (!login.ParseXml(value))
                        return false;
                    break;

                case "IPAddress":
                    if (!ipAddress.ParseXml(value))
                        return false;
                    break;

                case "StateUpdateLatency":
                    if (!stateUpdateLatency.ParseXml(value))
                        return false;
                    break;

                case "StateUpdatePeriod":
                    if (!stateUpdatePeriod.ParseXml(value))
                        return false;
                    break;

                case "LatestNetworkActivity":
                    if (!latestNetworkActivity.ParseXml(value))
                        return false;
                    break;

                case "NetworkLossRate":
                    if (!networkLossRate.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}