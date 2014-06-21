using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetServerOptions method call.
    /// </summary>
    public sealed class ReturnedServerOptionsStruct : BaseStruct<ReturnedServerOptionsStruct>
    {
        /// <summary>
        /// Backing field for the AllowChallengeDownload property.
        /// </summary>
        private XmlRpcBoolean allowChallengeDownload = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the AutoSaveReplays property.
        /// </summary>
        private XmlRpcBoolean autoSaveReplays = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the CallVoteRatio property.
        /// </summary>
        private XmlRpcDouble callVoteRatio = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the Comment property.
        /// </summary>
        private XmlRpcString comment = new XmlRpcString();

        /// <summary>
        /// Backing field for the CurrentCallVoteTimeOut property.
        /// </summary>
        private XmlRpcI4 currentCallVoteTimeOut = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentLadderMode property.
        /// </summary>
        private XmlRpcI4 currentLadderMode = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentMaxPlayers property.
        /// </summary>
        private XmlRpcI4 currentMaxPlayers = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentMaxSpectators property.
        /// </summary>
        private XmlRpcI4 currentMaxSpectators = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentVehicleNetQuality property.
        /// </summary>
        private XmlRpcI4 currentVehicleNetQuality = new XmlRpcI4();

        /// <summary>
        /// Backing field for the IsP2PDownload property.
        /// </summary>
        private XmlRpcBoolean isP2PDownload = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the IsP2PUpload property.
        /// </summary>
        private XmlRpcBoolean isP2PUpload = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the NextCallVoteTimeOut property.
        /// </summary>
        private XmlRpcI4 nextCallVoteTimeOut = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextLadderMode property.
        /// </summary>
        private XmlRpcI4 nextLadderMode = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextMaxPlayers property.
        /// </summary>
        private XmlRpcI4 nextMaxPlayers = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextMaxSpectators property.
        /// </summary>
        private XmlRpcI4 nextMaxSpectators = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextVehicleNetQuality property.
        /// </summary>
        private XmlRpcI4 nextVehicleNetQuality = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Password property.
        /// </summary>
        private XmlRpcString password = new XmlRpcString();

        /// <summary>
        /// Backing field for the PasswordForSpectator property.
        /// </summary>
        private XmlRpcString passwordForSpectator = new XmlRpcString();

        /// <summary>
        /// Gets whether clients are allowed to download the challenges from the server.
        /// </summary>
        public bool AllowChallengeDownload
        {
            get { return allowChallengeDownload.Value; }
        }

        /// <summary>
        /// Gets whether the server automatically saves replays of the players.
        /// </summary>
        public bool AutoSaveReplays
        {
            get { return autoSaveReplays.Value; }
        }

        /// <summary>
        /// Gets the Ratio for call-votes for this command. Range from 0-1, or -1 for disabled.
        /// </summary>
        public double CallVoteRatio
        {
            get { return callVoteRatio.Value; }
        }

        /// <summary>
        /// Gets the server comment.
        /// </summary>
        public string Comment
        {
            get { return comment.Value; }
        }

        /// <summary>
        /// Gets the current call-vote timeout in milliseconds.
        /// </summary>
        public int CurrentCallVoteTimeOut
        {
            get { return currentCallVoteTimeOut.Value; }
        }

        /// <summary>
        /// Gets the current ladder mode.. Compare to <see cref="ManiaNet.DedicatedServer.LadderModes"/> values.
        /// </summary>
        public int CurrentLadderMode
        {
            get { return currentLadderMode.Value; }
        }

        /// <summary>
        /// Gets the current maximum number of players.
        /// </summary>
        public int CurrentMaxPlayers
        {
            get { return currentMaxPlayers.Value; }
        }

        /// <summary>
        /// Gets the current maximum number of spectators.
        /// </summary>
        public int CurrentMaxSpectators
        {
            get { return currentMaxSpectators.Value; }
        }

        /// <summary>
        /// Gets the current vehicle quality. Compare to values from <see cref="ManiaNet.DedicatedServer.VehicleNetQualities"/>.
        /// </summary>
        public int CurrentVehicleNetQuality
        {
            get { return currentVehicleNetQuality.Value; }
        }

        /// <summary>
        /// Gets whether p2p download is active or not.
        /// </summary>
        public bool IsP2PDownload
        {
            get { return isP2PDownload.Value; }
        }

        /// <summary>
        /// Gets whether p2p upload is active or not.
        /// </summary>
        public bool IsP2PUpload
        {
            get { return isP2PUpload.Value; }
        }

        /// <summary>
        /// Gets the server name.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
        }

        /// <summary>
        /// Gets the next call-vote timeout in milliseconds.
        /// </summary>
        public int NextCallVoteTimeOut
        {
            get { return nextCallVoteTimeOut.Value; }
        }

        /// <summary>
        /// Gets the next ladder mode. Compare to Forced and Inactive constants in <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.LadderModeStruct"/>.
        /// </summary>
        public int NextLadderMode
        {
            get { return nextLadderMode.Value; }
        }

        /// <summary>
        /// Gets the next maximum number of players.
        /// </summary>
        public int NextMaxPlayers
        {
            get { return nextMaxPlayers.Value; }
        }

        /// <summary>
        /// Gets the next maximum number of spectators.
        /// </summary>
        public int NextMaxSpectators
        {
            get { return nextMaxSpectators.Value; }
        }

        /// <summary>
        /// Gets the next vehicle quality. Compare to values from <see cref="ManiaNet.DedicatedServer.VehicleNetQualities"/>.
        /// </summary>
        public int NextVehicleNetQuality
        {
            get { return nextVehicleNetQuality.Value; }
        }

        /// <summary>
        /// Gets the server password.
        /// </summary>
        public string Password
        {
            get { return password.Value; }
        }

        /// <summary>
        /// Gets the spectator password.
        /// </summary>
        public string PasswordForSpectator
        {
            get { return passwordForSpectator.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("Name", name.GenerateXml()),
                makeMemberElement("Comment", comment.GenerateXml()),
                makeMemberElement("Password", password.GenerateXml()),
                makeMemberElement("PasswordForSpectator", passwordForSpectator.GenerateXml()),
                makeMemberElement("CurrentMaxPlayers", currentMaxPlayers.GenerateXml()),
                makeMemberElement("NextMaxPlayers", nextMaxPlayers.GenerateXml()),
                makeMemberElement("CurrentMaxSpectators", currentMaxSpectators.GenerateXml()),
                makeMemberElement("NextMaxSpectators", nextMaxSpectators.GenerateXml()),
                makeMemberElement("IsP2PUpload", isP2PUpload.GenerateXml()),
                makeMemberElement("IsP2PDownload", isP2PDownload.GenerateXml()),
                makeMemberElement("CurrentLadderMode", currentLadderMode.GenerateXml()),
                makeMemberElement("NextLadderMode", nextLadderMode.GenerateXml()),
                makeMemberElement("CurrentVehicleNetQuality", nextLadderMode.GenerateXml()),
                makeMemberElement("NextVehicleNetQuality", nextVehicleNetQuality.GenerateXml()),
                makeMemberElement("CurrentCallVoteTimeOut", currentCallVoteTimeOut.GenerateXml()),
                makeMemberElement("NextCallVoteTimeOut", nextCallVoteTimeOut.GenerateXml()),
                makeMemberElement("CallVoteRatio", callVoteRatio.GenerateXml()),
                makeMemberElement("AllowChallengeDownload", allowChallengeDownload.GenerateXml()),
                makeMemberElement("AutoSaveReplays", autoSaveReplays.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override ReturnedServerOptionsStruct ParseXml(XElement xElement)
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

                    case "Comment":
                        comment.ParseXml(getValueContent(value, comment.ElementName));
                        break;

                    case "Password":
                        password.ParseXml(getValueContent(value, password.ElementName));
                        break;

                    case "PasswordForSpectator":
                        passwordForSpectator.ParseXml(getValueContent(value, passwordForSpectator.ElementName));
                        break;

                    case "CurrentMaxPlayers":
                        currentMaxPlayers.ParseXml(getValueContent(value, currentMaxPlayers.ElementName));
                        break;

                    case "NextMaxPlayers":
                        nextMaxPlayers.ParseXml(getValueContent(value, nextMaxPlayers.ElementName));
                        break;

                    case "CurrentMaxSpectators":
                        currentMaxSpectators.ParseXml(getValueContent(value, currentMaxSpectators.ElementName));
                        break;

                    case "NextMaxSpectators":
                        nextMaxSpectators.ParseXml(getValueContent(value, nextMaxSpectators.ElementName));
                        break;

                    case "IsP2PUpload":
                        isP2PUpload.ParseXml(getValueContent(value, isP2PUpload.ElementName));
                        break;

                    case "IsP2PDownload":
                        isP2PDownload.ParseXml(getValueContent(value, isP2PDownload.ElementName));
                        break;

                    case "CurrentLadderMode":
                        currentLadderMode.ParseXml(getValueContent(value, currentLadderMode.ElementName));
                        break;

                    case "NextLadderMode":
                        nextLadderMode.ParseXml(getValueContent(value, nextLadderMode.ElementName));
                        break;

                    case "CurrentVehicleNetQuality":
                        currentVehicleNetQuality.ParseXml(getValueContent(value, currentVehicleNetQuality.ElementName));
                        break;

                    case "NextVehicleNetQuality":
                        nextVehicleNetQuality.ParseXml(getValueContent(value, nextVehicleNetQuality.ElementName));
                        break;

                    case "CurrentCallVoteTimeOut":
                        currentCallVoteTimeOut.ParseXml(getValueContent(value, currentCallVoteTimeOut.ElementName));
                        break;

                    case "NextCallVoteTimeOut":
                        nextCallVoteTimeOut.ParseXml(getValueContent(value, nextCallVoteTimeOut.ElementName));
                        break;

                    case "CallVoteRatio":
                        callVoteRatio.ParseXml(getValueContent(value, callVoteRatio.ElementName));
                        break;

                    case "AllowChallengeDownload":
                        allowChallengeDownload.ParseXml(getValueContent(value, allowChallengeDownload.ElementName));
                        break;

                    case "AutoSaveReplays":
                        autoSaveReplays.ParseXml(getValueContent(value, autoSaveReplays.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}