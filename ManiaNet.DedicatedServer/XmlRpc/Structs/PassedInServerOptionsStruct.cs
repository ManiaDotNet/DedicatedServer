using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    public sealed class PassedInServerOptionsStruct : BaseStruct
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
        /// Gets or sets whether clients are allowed to download the challenges from the server.
        /// </summary>
        public bool AllowChallengeDownload
        {
            get { return allowChallengeDownload.Value; }
            set { allowChallengeDownload.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the server automatically saves replays of the players.
        /// </summary>
        public bool AutoSaveReplays
        {
            get { return autoSaveReplays.Value; }
            set { autoSaveReplays.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Ratio for call-votes for this command. Range from 0-1, or -1 for disabled.
        /// </summary>
        public double CallVoteRatio
        {
            get { return callVoteRatio.Value; }
            set
            {
                if (value != -1 && (value < 0 || value > 1))
                    throw new ArgumentOutOfRangeException("value", "Ratio has to be between 0 and 1, or -1.");

                callVoteRatio.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the server comment.
        /// </summary>
        public string Comment
        {
            get { return comment.Value; }
            set { comment.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether p2p download is active or not.
        /// </summary>
        public bool IsP2PDownload
        {
            get { return isP2PDownload.Value; }
            set { isP2PDownload.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether p2p upload is active or not.
        /// </summary>
        public bool IsP2PUpload
        {
            get { return isP2PUpload.Value; }
            set { isP2PUpload.Value = value; }
        }

        /// <summary>
        /// Gets or sets the server name.
        /// </summary>
        public string Name
        {
            get { return name.Value; }
            set { name.Value = value; }
        }

        /// <summary>
        /// Gets or sets the next call-vote timeout in milliseconds.
        /// </summary>
        public int NextCallVoteTimeOut
        {
            get { return nextCallVoteTimeOut.Value; }
            set { nextCallVoteTimeOut.Value = value; }
        }

        /// <summary>
        /// Gets or sets the next ladder mode. Compare to <see cref="ManiaNet.DedicatedServer.LadderModes"/> values.
        /// </summary>
        public int NextLadderMode
        {
            get { return nextLadderMode.Value; }
            set
            {
                if (value != LadderModes.Inactive && value != LadderModes.Forced)
                    throw new ArgumentOutOfRangeException("value", "Ladder mode has to one of the values from the LadderModes class.");

                nextLadderMode.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the next maximum number of players.
        /// </summary>
        public int NextMaxPlayers
        {
            get { return nextMaxPlayers.Value; }
            set
            {
                nextMaxPlayers.Value = value > 0 ? value : 1;
            }
        }

        /// <summary>
        /// Gets or sets the next maximum number of spectators.
        /// </summary>
        public int NextMaxSpectators
        {
            get { return nextMaxSpectators.Value; }
            set
            {
                nextMaxSpectators.Value = value > -1 ? value : 0;
            }
        }

        /// <summary>
        /// Gets or sets the next vehicle quality. Use values from <see cref="ManiaNet.DedicatedServer.VehicleNetQualities"/>.
        /// </summary>
        public int NextVehicleNetQuality
        {
            get { return nextVehicleNetQuality.Value; }
            set
            {
                nextVehicleNetQuality.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the server password.
        /// </summary>
        public string Password
        {
            get { return password.Value; }
            set { password.Value = value; }
        }

        /// <summary>
        /// Gets or sets the spectator password.
        /// </summary>
        public string PasswordForSpectator
        {
            get { return passwordForSpectator.Value; }
            set { passwordForSpectator.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.PassedInServerOptionsStruct"/> class without content (for parsing from Xml).
        /// </summary>
        public PassedInServerOptionsStruct()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.PassedInServerOptionsStruct"/> class with from the given server options.
        /// </summary>
        /// <param name="serverOptions">The server options to use for the creation.</param>
        public PassedInServerOptionsStruct(ReturnedServerOptionsStruct serverOptions)
        {
            Name = serverOptions.Name;
            Comment = serverOptions.Comment;
            Password = serverOptions.Password;
            PasswordForSpectator = serverOptions.PasswordForSpectator;
            NextMaxPlayers = serverOptions.NextMaxPlayers;
            IsP2PUpload = serverOptions.IsP2PUpload;
            IsP2PDownload = serverOptions.IsP2PDownload;
            NextLadderMode = serverOptions.NextLadderMode;
            NextVehicleNetQuality = serverOptions.NextVehicleNetQuality;
            NextCallVoteTimeOut = serverOptions.NextCallVoteTimeOut;
            AllowChallengeDownload = serverOptions.AllowChallengeDownload;
            AutoSaveReplays = serverOptions.AutoSaveReplays;
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
                makeMemberElement("NextMaxPlayers", nextMaxPlayers),
                makeMemberElement("IsP2PUpload", isP2PUpload),
                makeMemberElement("IsP2PDownload", isP2PDownload),
                makeMemberElement("NextLadderMode", nextLadderMode),
                makeMemberElement("NextVehicleNetQuality", nextVehicleNetQuality),
                makeMemberElement("NextCallVoteTimeOut", nextCallVoteTimeOut),
                makeMemberElement("CallVoteRatio", callVoteRatio),
                makeMemberElement("AllowChallengeDownload", allowChallengeDownload),
                makeMemberElement("AutoSaveReplays", autoSaveReplays));
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

                case "NextMaxPlayers":
                    if (!nextMaxPlayers.ParseXml(value))
                        return false;
                    break;

                case "NextMaxSpectators":
                    if (!nextMaxSpectators.ParseXml(value))
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

                case "NextLadderMode":
                    if (!nextLadderMode.ParseXml(value))
                        return false;
                    break;

                case "NextVehicleNetQuality":
                    if (!nextVehicleNetQuality.ParseXml(value))
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

                case "AllowChallengeDownload":
                    if (!allowChallengeDownload.ParseXml(value))
                        return false;
                    break;

                case "AutoSaveReplays":
                    if (!autoSaveReplays.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}