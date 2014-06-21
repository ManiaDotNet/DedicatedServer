using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetNetworkStats method call.
    /// </summary>
    public sealed class NetworkStatsStruct : BaseStruct<NetworkStatsStruct>
    {
        /// <summary>
        /// Backing field for the MeanConnectionTime property.
        /// </summary>
        private XmlRpcI4 meanConnectionTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the MeanNbrPlayer property.
        /// </summary>
        private XmlRpcI4 meanNbrPlayer = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NbrConnection property.
        /// </summary>
        private XmlRpcI4 nbrConnection = new XmlRpcI4();

        /// <summary>
        /// Backing field for the PlayerNetInfos property.
        /// </summary>
        private XmlRpcArray<XmlRpcStruct<PlayerNetInfoStruct>, PlayerNetInfoStruct> playerNetInfos = new XmlRpcArray<XmlRpcStruct<PlayerNetInfoStruct>, PlayerNetInfoStruct>();

        /// <summary>
        /// Backing field for the RecvNetRate property.
        /// </summary>
        private XmlRpcI4 recvNetRate = new XmlRpcI4();

        /// <summary>
        /// Backing field for the SendNetRate property.
        /// </summary>
        private XmlRpcI4 sendNetRate = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TotalReceivingSize property.
        /// </summary>
        private XmlRpcI4 totalReceivingSize = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TotalSendingSize property.
        /// </summary>
        private XmlRpcI4 totalSendingSize = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Uptime property.
        /// </summary>
        private XmlRpcI4 uptime = new XmlRpcI4();

        /// <summary>
        /// Gets the mean connection time of players in seconds.
        /// </summary>
        public int MeanConnectionTime
        {
            get { return meanConnectionTime.Value; }
        }

        /// <summary>
        /// Gets the mean number of players on the server.
        /// </summary>
        public int MeanNbrPlayer
        {
            get { return meanNbrPlayer.Value; }
        }

        /// <summary>
        /// Gets the total number of connections.
        /// </summary>
        public int NbrConnection
        {
            get { return nbrConnection.Value; }
        }

        /// <summary>
        /// Gets the player network infos.
        /// </summary>
        public IEnumerable<PlayerNetInfoStruct> PlayerNetInfos
        {
            get { return playerNetInfos.Value.Select(xmlRpcStruct => xmlRpcStruct.Value); }
        }

        /// <summary>
        /// Gets the receive rate of the server in kbit per second.
        /// </summary>
        public int RecvNetRate
        {
            get { return recvNetRate.Value; }
        }

        /// <summary>
        /// Gets the send rate of the server in kbits per second.
        /// </summary>
        public int SendNetRate
        {
            get { return sendNetRate.Value; }
        }

        /// <summary>
        /// Gets the total number of kbytes received by the server.
        /// </summary>
        public int TotalReceivingSize
        {
            get { return totalReceivingSize.Value; }
        }

        /// <summary>
        /// Gets the total number of kbytes sent by the server.
        /// </summary>
        public int TotalSendingSize
        {
            get { return totalSendingSize.Value; }
        }

        /// <summary>
        /// Gets the number of seconds the server has been running.
        /// </summary>
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
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Uptime", uptime.GenerateXml()),
                makeMemberElement("NbrConnection", nbrConnection.GenerateXml()),
                makeMemberElement("MeanConnectionTime", meanConnectionTime.GenerateXml()),
                makeMemberElement("MeanNbrPlayer", meanNbrPlayer.GenerateXml()),
                makeMemberElement("RecvNetRate", recvNetRate.GenerateXml()),
                makeMemberElement("SendNetRate", sendNetRate.GenerateXml()),
                makeMemberElement("TotalReceivingSize", totalReceivingSize.GenerateXml()),
                makeMemberElement("TotalSendingSize", totalSendingSize.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override NetworkStatsStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "Uptime":
                        uptime.ParseXml(getValueContent(value, uptime.ElementName));
                        break;

                    case "NbrConnection":
                        nbrConnection.ParseXml(getValueContent(value, nbrConnection.ElementName));
                        break;

                    case "MeanConnectionTime":
                        meanConnectionTime.ParseXml(getValueContent(value, meanConnectionTime.ElementName));
                        break;

                    case "MeanNbrPlayer":
                        meanNbrPlayer.ParseXml(getValueContent(value, meanNbrPlayer.ElementName));
                        break;

                    case "RecvNetRate":
                        recvNetRate.ParseXml(getValueContent(value, recvNetRate.ElementName));
                        break;

                    case "SendNetRate":
                        sendNetRate.ParseXml(getValueContent(value, sendNetRate.ElementName));
                        break;

                    case "TotalReceivingSize":
                        totalReceivingSize.ParseXml(getValueContent(value, totalReceivingSize.ElementName));
                        break;

                    case "TotalSendingSize":
                        totalSendingSize.ParseXml(getValueContent(value, totalSendingSize.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}