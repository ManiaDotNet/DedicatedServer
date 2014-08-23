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
    /// Represents the struct returned by the GetNetworkStats method call.
    /// </summary>
    public sealed class NetworkStatsStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the MeanConnectionTime property.
        /// </summary>
        private readonly XmlRpcI4 meanConnectionTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the MeanNbrPlayer property.
        /// </summary>
        private readonly XmlRpcI4 meanNbrPlayer = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NbrConnection property.
        /// </summary>
        private readonly XmlRpcI4 nbrConnection = new XmlRpcI4();

        /// <summary>
        /// Backing field for the PlayerNetInfos property.
        /// </summary>
        private readonly XmlRpcArray<XmlRpcStruct<PlayerNetInfoStruct>, PlayerNetInfoStruct> playerNetInfos =
            new XmlRpcArray<XmlRpcStruct<PlayerNetInfoStruct>, PlayerNetInfoStruct>();

        /// <summary>
        /// Backing field for the RecvNetRate property.
        /// </summary>
        private readonly XmlRpcI4 recvNetRate = new XmlRpcI4();

        /// <summary>
        /// Backing field for the SendNetRate property.
        /// </summary>
        private readonly XmlRpcI4 sendNetRate = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TotalReceivingSize property.
        /// </summary>
        private readonly XmlRpcI4 totalReceivingSize = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TotalSendingSize property.
        /// </summary>
        private readonly XmlRpcI4 totalSendingSize = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Uptime property.
        /// </summary>
        private readonly XmlRpcI4 uptime = new XmlRpcI4();

        /// <summary>
        /// Gets the mean connection time of players in seconds.
        /// </summary>
        [UsedImplicitly]
        public int MeanConnectionTime
        {
            get { return meanConnectionTime.Value; }
        }

        /// <summary>
        /// Gets the mean number of players on the server.
        /// </summary>
        [UsedImplicitly]
        public int MeanNbrPlayer
        {
            get { return meanNbrPlayer.Value; }
        }

        /// <summary>
        /// Gets the total number of connections.
        /// </summary>
        [UsedImplicitly]
        public int NbrConnection
        {
            get { return nbrConnection.Value; }
        }

        /// <summary>
        /// Gets the player network infos.
        /// </summary>
        [NotNull, UsedImplicitly]
        public IEnumerable<PlayerNetInfoStruct> PlayerNetInfos
        {
            get { return playerNetInfos.Value.Select(xmlRpcStruct => xmlRpcStruct.Value); }
        }

        /// <summary>
        /// Gets the receive rate of the server in kbit per second.
        /// </summary>
        [UsedImplicitly]
        public int RecvNetRate
        {
            get { return recvNetRate.Value; }
        }

        /// <summary>
        /// Gets the send rate of the server in kbits per second.
        /// </summary>
        [UsedImplicitly]
        public int SendNetRate
        {
            get { return sendNetRate.Value; }
        }

        /// <summary>
        /// Gets the total number of kbytes received by the server.
        /// </summary>
        [UsedImplicitly]
        public int TotalReceivingSize
        {
            get { return totalReceivingSize.Value; }
        }

        /// <summary>
        /// Gets the total number of kbytes sent by the server.
        /// </summary>
        [UsedImplicitly]
        public int TotalSendingSize
        {
            get { return totalSendingSize.Value; }
        }

        /// <summary>
        /// Gets the number of seconds the server has been running.
        /// </summary>
        [UsedImplicitly]
        public int Uptime
        {
            get { return uptime.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Uptime", uptime),
                makeMemberElement("NbrConnection", nbrConnection),
                makeMemberElement("MeanConnectionTime", meanConnectionTime),
                makeMemberElement("MeanNbrPlayer", meanNbrPlayer),
                makeMemberElement("RecvNetRate", recvNetRate),
                makeMemberElement("SendNetRate", sendNetRate),
                makeMemberElement("TotalReceivingSize", totalReceivingSize),
                makeMemberElement("TotalSendingSize", totalSendingSize));
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
                case "Uptime":
                    if (!uptime.ParseXml(value))
                        return false;
                    break;

                case "NbrConnection":
                    if (!nbrConnection.ParseXml(value))
                        return false;
                    break;

                case "MeanConnectionTime":
                    if (!meanConnectionTime.ParseXml(value))
                        return false;
                    break;

                case "MeanNbrPlayer":
                    if (!meanNbrPlayer.ParseXml(value))
                        return false;
                    break;

                case "RecvNetRate":
                    if (!recvNetRate.ParseXml(value))
                        return false;
                    break;

                case "SendNetRate":
                    if (!sendNetRate.ParseXml(value))
                        return false;
                    break;

                case "TotalReceivingSize":
                    if (!totalReceivingSize.ParseXml(value))
                        return false;
                    break;

                case "TotalSendingSize":
                    if (!totalSendingSize.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}