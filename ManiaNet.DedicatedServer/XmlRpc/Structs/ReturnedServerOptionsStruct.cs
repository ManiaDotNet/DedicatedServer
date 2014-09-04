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
    /// Represents the struct returned by the GetServerOptions method call.
    /// </summary>
    public sealed class ReturnedServerOptionsStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the AllowChallengeDownload property.
        /// </summary>
        private readonly XmlRpcBoolean allowChallengeDownload = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the AutoSaveReplays property.
        /// </summary>
        private readonly XmlRpcBoolean autoSaveReplays = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the AutoSaveValidationReplays property.
        /// </summary>
        private readonly XmlRpcBoolean autoSaveValidationReplays = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the CallVoteRatio property.
        /// </summary>
        private readonly XmlRpcDouble callVoteRatio = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the ClientInputsMaxLatency property.
        /// </summary>
        private readonly XmlRpcI4 clientInputsMaxLatency = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Comment property.
        /// </summary>
        private readonly XmlRpcString comment = new XmlRpcString();

        /// <summary>
        /// Backing field for the CurrentCallVoteTimeOut property.
        /// </summary>
        private readonly XmlRpcI4 currentCallVoteTimeOut = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentLadderMode property.
        /// </summary>
        private readonly XmlRpcI4 currentLadderMode = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentMaxPlayers property.
        /// </summary>
        private readonly XmlRpcI4 currentMaxPlayers = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentMaxSpectators property.
        /// </summary>
        private readonly XmlRpcI4 currentMaxSpectators = new XmlRpcI4();

        /// <summary>
        /// Backing field for the CurrentUseChangingValidationSeed property.
        /// </summary>
        private readonly XmlRpcBoolean currentUseChangingValidationSeed = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the CurrentVehicleNetQuality property.
        /// </summary>
        private readonly XmlRpcI4 currentVehicleNetQuality = new XmlRpcI4();

        /// <summary>
        /// Backing field for the DisableHorns property.
        /// </summary>
        private readonly XmlRpcBoolean disableHorns = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the DisableServiceAnnouncements property.
        /// </summary>
        private readonly XmlRpcBoolean disableServiceAnnouncements = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the HideServer Property.
        /// </summary>
        private readonly XmlRpcI4 hideServer = new XmlRpcI4();

        /// <summary>
        /// Backing field for the IsP2PDownload property.
        /// </summary>
        private readonly XmlRpcBoolean isP2PDownload = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the IsP2PUpload property.
        /// </summary>
        private readonly XmlRpcBoolean isP2PUpload = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the KeepPlayerSlots property.
        /// </summary>
        private readonly XmlRpcBoolean keepPlayerSlots = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the LadderServerLimitMax property.
        /// </summary>
        private readonly XmlRpcDouble ladderServerLimitMax = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the LadderServerLimitMin property.
        /// </summary>
        private readonly XmlRpcDouble ladderServerLimitMin = new XmlRpcDouble();

        /// <summary>
        /// Backing field for the Name property.
        /// </summary>
        private readonly XmlRpcString name = new XmlRpcString();

        /// <summary>
        /// Backing field for the NextCallVoteTimeOut property.
        /// </summary>
        private readonly XmlRpcI4 nextCallVoteTimeOut = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextLadderMode property.
        /// </summary>
        private readonly XmlRpcI4 nextLadderMode = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextMaxPlayers property.
        /// </summary>
        private readonly XmlRpcI4 nextMaxPlayers = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextMaxSpectators property.
        /// </summary>
        private readonly XmlRpcI4 nextMaxSpectators = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NextUseChangingValidationSeed property.
        /// </summary>
        private readonly XmlRpcBoolean nextUseChangingValidationSeed = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the NextVehicleNetQuality property.
        /// </summary>
        private readonly XmlRpcI4 nextVehicleNetQuality = new XmlRpcI4();

        /// <summary>
        /// Backing field for the Password property.
        /// </summary>
        private readonly XmlRpcString password = new XmlRpcString();

        /// <summary>
        /// Backing field for the PasswordForSpectator property.
        /// </summary>
        private readonly XmlRpcString passwordForSpectator = new XmlRpcString();

        /// <summary>
        /// Backing field for the RefereeMode property.
        /// </summary>
        private readonly XmlRpcI4 refereeMode = new XmlRpcI4();

        /// <summary>
        /// Backing field for the RefereePassword property.
        /// </summary>
        private readonly XmlRpcString refereePassword = new XmlRpcString();

        /// <summary>
        /// Gets whether clients are allowed to download the challenges from the server.
        /// </summary>
        [UsedImplicitly]
        public bool AllowChallengeDownload
        {
            get { return allowChallengeDownload.Value; }
        }

        /// <summary>
        /// Gets whether the server automatically saves replays of the players.
        /// </summary>
        [UsedImplicitly]
        public bool AutoSaveReplays
        {
            get { return autoSaveReplays.Value; }
        }

        /// <summary>
        /// Gets whether validation replays will be saved automatically or not.
        /// </summary>
        [UsedImplicitly]
        public bool AutoSaveValidationReplays
        {
            get { return autoSaveValidationReplays.Value; }
        }

        /// <summary>
        /// Gets the Ratio for call-votes for this command. Range from 0-1, or -1 for disabled.
        /// </summary>
        [UsedImplicitly]
        public double CallVoteRatio
        {
            get { return callVoteRatio.Value; }
        }

        /// <summary>
        /// Gets the max latency for client inputs. 0 means it adapts.
        /// </summary>
        [UsedImplicitly]
        public int ClientInputsMaxLatency
        {
            get { return clientInputsMaxLatency.Value; }
        }

        /// <summary>
        /// Gets the server comment.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Comment
        {
            get { return comment.Value; }
        }

        /// <summary>
        /// Gets the current call-vote timeout in milliseconds.
        /// </summary>
        [UsedImplicitly]
        public int CurrentCallVoteTimeOut
        {
            get { return currentCallVoteTimeOut.Value; }
        }

        /// <summary>
        /// Gets the current ladder mode.. Compare to <see cref="ManiaNet.DedicatedServer.LadderModes"/> values.
        /// </summary>
        [UsedImplicitly]
        public int CurrentLadderMode
        {
            get { return currentLadderMode.Value; }
        }

        /// <summary>
        /// Gets the current maximum number of players.
        /// </summary>
        [UsedImplicitly]
        public int CurrentMaxPlayers
        {
            get { return currentMaxPlayers.Value; }
        }

        /// <summary>
        /// Gets the current maximum number of spectators.
        /// </summary>
        [UsedImplicitly]
        public int CurrentMaxSpectators
        {
            get { return currentMaxSpectators.Value; }
        }

        /// <summary>
        /// Gets whether a changing validation seed is used currently.
        /// </summary>
        [UsedImplicitly]
        public bool CurrentUseChangingValidationSeed
        {
            get { return currentUseChangingValidationSeed.Value; }
        }

        /// <summary>
        /// Gets the current vehicle quality. Compare to values from <see cref="ManiaNet.DedicatedServer.VehicleNetQualities"/>.
        /// </summary>
        [UsedImplicitly]
        public int CurrentVehicleNetQuality
        {
            get { return currentVehicleNetQuality.Value; }
        }

        /// <summary>
        /// Gets whether horns are disabled or not.
        /// </summary>
        [UsedImplicitly]
        public bool DisableHorns
        {
            get { return disableHorns.Value; }
        }

        /// <summary>
        /// Gets whether service announcements are disabled or not.
        /// </summary>
        [UsedImplicitly]
        public bool DisableServiceAnnouncements
        {
            get { return disableServiceAnnouncements.Value; }
        }

        /// <summary>
        /// Gets the hide-server value.
        /// </summary>
        [UsedImplicitly]
        public int HideServer
        {
            get { return hideServer.Value; }
        }

        /// <summary>
        /// Gets whether p2p download is active or not.
        /// </summary>
        [UsedImplicitly]
        public bool IsP2PDownload
        {
            get { return isP2PDownload.Value; }
        }

        /// <summary>
        /// Gets whether p2p upload is active or not.
        /// </summary>
        [UsedImplicitly]
        public bool IsP2PUpload
        {
            get { return isP2PUpload.Value; }
        }

        /// <summary>
        /// Gets whether the Player slots of Players turned Spectator are counted.
        /// </summary>
        [UsedImplicitly]
        public bool KeepPlayerSlots
        {
            get { return keepPlayerSlots.Value; }
        }

        /// <summary>
        /// Gets the maximum ladder points able to be achieved on the server.
        /// </summary>
        [UsedImplicitly]
        public double LadderServerLimitMax
        {
            get { return ladderServerLimitMax.Value; }
        }

        /// <summary>
        /// Gets the minimum ladder points required to join the server.
        /// </summary>
        [UsedImplicitly]
        public double LadderServerLimitMin
        {
            get { return ladderServerLimitMin.Value; }
        }

        /// <summary>
        /// Gets the server name.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Name
        {
            get { return name.Value; }
        }

        /// <summary>
        /// Gets the next call-vote timeout in milliseconds.
        /// </summary>
        [UsedImplicitly]
        public int NextCallVoteTimeOut
        {
            get { return nextCallVoteTimeOut.Value; }
        }

        /// <summary>
        /// Gets the next ladder mode. Compare to Forced and Inactive constants in <see cref="ManiaNet.DedicatedServer.LadderModes"/>.
        /// </summary>
        [UsedImplicitly]
        public int NextLadderMode
        {
            get { return nextLadderMode.Value; }
        }

        /// <summary>
        /// Gets the next maximum number of players.
        /// </summary>
        [UsedImplicitly]
        public int NextMaxPlayers
        {
            get { return nextMaxPlayers.Value; }
        }

        /// <summary>
        /// Gets the next maximum number of spectators.
        /// </summary>
        [UsedImplicitly]
        public int NextMaxSpectators
        {
            get { return nextMaxSpectators.Value; }
        }

        /// <summary>
        /// Gets whether a changing validation seed will be used next.
        /// </summary>
        [UsedImplicitly]
        public bool NextUseChangingValidationSeed
        {
            get { return nextUseChangingValidationSeed.Value; }
        }

        /// <summary>
        /// Gets the next vehicle quality. Compare to values from <see cref="ManiaNet.DedicatedServer.VehicleNetQualities"/>.
        /// </summary>
        [UsedImplicitly]
        public int NextVehicleNetQuality
        {
            get { return nextVehicleNetQuality.Value; }
        }

        /// <summary>
        /// Gets the server password.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Password
        {
            get { return password.Value; }
        }

        /// <summary>
        /// Gets the spectator password.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string PasswordForSpectator
        {
            get { return passwordForSpectator.Value; }
        }

        /// <summary>
        /// Gets the referee mode.
        /// </summary>
        [UsedImplicitly]
        public int RefereeMode
        {
            get { return refereeMode.Value; }
        }

        /// <summary>
        /// Gets the referee password.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string RefereePassword
        {
            get { return refereePassword.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Name", name),
                makeMemberElement("Comment", comment),
                makeMemberElement("Password", password),
                makeMemberElement("PasswordForSpectator", passwordForSpectator),
                makeMemberElement("HideServer", hideServer),
                makeMemberElement("CurrentMaxPlayers", currentMaxPlayers),
                makeMemberElement("NextMaxPlayers", nextMaxPlayers),
                makeMemberElement("CurrentMaxSpectators", currentMaxSpectators),
                makeMemberElement("NextMaxSpectators", nextMaxSpectators),
                makeMemberElement("KeepPlayerSlots", keepPlayerSlots),
                makeMemberElement("IsP2PUpload", isP2PUpload),
                makeMemberElement("IsP2PDownload", isP2PDownload),
                makeMemberElement("CurrentLadderMode", currentLadderMode),
                makeMemberElement("NextLadderMode", nextLadderMode),
                makeMemberElement("LadderServerLimitMax", ladderServerLimitMax),
                makeMemberElement("LadderServerLimitMin", ladderServerLimitMin),
                makeMemberElement("CurrentVehicleNetQuality", nextLadderMode),
                makeMemberElement("NextVehicleNetQuality", nextVehicleNetQuality),
                makeMemberElement("CurrentCallVoteTimeOut", currentCallVoteTimeOut),
                makeMemberElement("NextCallVoteTimeOut", nextCallVoteTimeOut),
                makeMemberElement("CallVoteRatio", callVoteRatio),
                makeMemberElement("AllowMapDownload", allowChallengeDownload),
                makeMemberElement("AutoSaveReplays", autoSaveReplays),
                makeMemberElement("AutoSaveValidationReplays", autoSaveValidationReplays),
                makeMemberElement("RefereePassword", refereePassword),
                makeMemberElement("RefereeMode", refereeMode),
                makeMemberElement("CurrentUseChangingValidationSeed", currentUseChangingValidationSeed),
                makeMemberElement("NextUseChangingValidationSeed", nextUseChangingValidationSeed),
                makeMemberElement("ClientInputsMaxLatency", clientInputsMaxLatency),
                makeMemberElement("DisableHorns", disableHorns),
                makeMemberElement("DisableServiceAnnounces", disableServiceAnnouncements)); // sic
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
                case "Name":
                    if (!name.ParseXml(value))
                        return false;
                    break;

                case "Comment":
                    if (!comment.ParseXml(value))
                        return false;
                    break;

                case "Password":
                    if (!password.ParseXml(value))
                        return false;
                    break;

                case "PasswordForSpectator":
                    if (!passwordForSpectator.ParseXml(value))
                        return false;
                    break;

                case "HideServer":
                    if (!hideServer.ParseXml(value))
                        return false;
                    break;

                case "CurrentMaxPlayers":
                    if (!currentMaxPlayers.ParseXml(value))
                        return false;
                    break;

                case "NextMaxPlayers":
                    if (!nextMaxPlayers.ParseXml(value))
                        return false;
                    break;

                case "CurrentMaxSpectators":
                    if (!currentMaxSpectators.ParseXml(value))
                        return false;
                    break;

                case "NextMaxSpectators":
                    if (!nextMaxSpectators.ParseXml(value))
                        return false;
                    break;

                case "KeepPlayerSlots":
                    if (!keepPlayerSlots.ParseXml(value))
                        return false;
                    break;

                case "IsP2PUpload":
                    if (!isP2PUpload.ParseXml(value))
                        return false;
                    break;

                case "IsP2PDownload":
                    if (!isP2PDownload.ParseXml(value))
                        return false;
                    break;

                case "CurrentLadderMode":
                    if (!currentLadderMode.ParseXml(value))
                        return false;
                    break;

                case "NextLadderMode":
                    if (!nextLadderMode.ParseXml(value))
                        return false;
                    break;

                case "LadderServerLimitMax":
                    if (!ladderServerLimitMax.ParseXml(value))
                        return false;
                    break;

                case "LadderServerLimitMin":
                    if (!ladderServerLimitMin.ParseXml(value))
                        return false;
                    break;

                case "CurrentVehicleNetQuality":
                    if (!currentVehicleNetQuality.ParseXml(value))
                        return false;
                    break;

                case "NextVehicleNetQuality":
                    if (!nextVehicleNetQuality.ParseXml(value))
                        return false;
                    break;

                case "CurrentCallVoteTimeOut":
                    if (!currentCallVoteTimeOut.ParseXml(value))
                        return false;
                    break;

                case "NextCallVoteTimeOut":
                    if (!nextCallVoteTimeOut.ParseXml(value))
                        return false;
                    break;

                case "CallVoteRatio":
                    if (!callVoteRatio.ParseXml(value))
                        return false;
                    break;

                case "AllowMapDownload":
                    if (!allowChallengeDownload.ParseXml(value))
                        return false;
                    break;

                case "AutoSaveReplays":
                    if (!autoSaveReplays.ParseXml(value))
                        return false;
                    break;

                case "AutoSaveValidationReplays":
                    if (!autoSaveValidationReplays.ParseXml(value))
                        return false;
                    break;

                case "RefereePassword":
                    if (!refereePassword.ParseXml(value))
                        return false;
                    break;

                case "RefereeMode":
                    if (!refereeMode.ParseXml(value))
                        return false;
                    break;

                case "CurrentUseChangingValidationSeed":
                    if (!currentUseChangingValidationSeed.ParseXml(value))
                        return false;
                    break;

                case "NextUseChangingValidationSeed":
                    if (!nextUseChangingValidationSeed.ParseXml(value))
                        return false;
                    break;

                case "ClientInputsMaxLatency":
                    if (!clientInputsMaxLatency.ParseXml(value))
                        return false;
                    break;

                case "DisableHorns":
                    if (!disableHorns.ParseXml(value))
                        return false;
                    break;

                case "DisableServiceAnnounces": // sic
                    if (!disableServiceAnnouncements.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}