using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the struct passed to the SetGameInfos method call.
    /// </summary>
    public sealed class PassedInGameInfosStruct : BaseStruct<PassedInGameInfosStruct>
    {
        /// <summary>
        /// Backing field for the ChatTime property.
        /// </summary>
        private XmlRpcI4 chatTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the FinishTimeout property.
        /// </summary>
        private XmlRpcI4 finishTimeout = new XmlRpcI4();

        /// <summary>
        /// Backing field for the GameMode property.
        /// </summary>
        private XmlRpcI4 gameMode = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LapsNbLaps property.
        /// </summary>
        private XmlRpcI4 lapsNbLaps = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LapsTimeLimit property.
        /// </summary>
        private XmlRpcI4 lapsTimeLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the RoundsForcedLaps property.
        /// </summary>

        private XmlRpcI4 roundsForcedLaps = new XmlRpcI4();

        /// <summary>
        /// Backing field for the RoundsPointsLimit property.
        /// </summary>
        private XmlRpcI4 roundsPointsLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the RoundsUseNewRules property.
        /// </summary>
        private XmlRpcBoolean roundsUseNewRules = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the TeamMaxPoints property.
        /// </summary>
        private XmlRpcI4 teamMaxPoints = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TeamPointsLimit property.
        /// </summary>
        private XmlRpcI4 teamPointsLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TeamUseNewRules property.
        /// </summary>
        private XmlRpcBoolean teamUseNewRules = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the TimeAttackLimit property.
        /// </summary>
        private XmlRpcI4 timeAttackLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TimeAttackSynchStartPeriod property.
        /// </summary>
        private XmlRpcI4 timeAttackSynchStartPeriod = new XmlRpcI4();

        /// <summary>
        /// Gets or sets the chat time at the end of the map in milliseconds.
        /// </summary>
        public int ChatTime
        {
            get { return chatTime.Value; }
            set
            {
                chatTime.Value = value > 0 ? value : 0;
            }
        }

        /// <summary>
        /// Gets or sets the finish timeout in seconds.
        /// </summary>
        public int FinishTimeout
        {
            get { return finishTimeout.Value; }
            set
            {
                finishTimeout.Value = value > 0 ? value : 0;
            }
        }

        /// <summary>
        /// Gets or sets the gamemode. Compare to <see cref="ManiaNet.DedicatedServer.GameModes"/> values.
        /// </summary>
        public int GameMode
        {
            get { return gameMode.Value; }
            set
            {
                if (value != GameModes.Script &&
                    value != GameModes.Rounds &&
                    value != GameModes.TimeAttack &&
                    value != GameModes.Team &&
                    value != GameModes.Laps &&
                    value != GameModes.Cup &&
                    value != GameModes.Stunts)
                    throw new ArgumentOutOfRangeException("value", "Game mode has to be one of the values from the GameModes class.");

                gameMode.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of laps players have to drive in laps mode.
        /// </summary>
        public int LapsNbLaps
        {
            get { return lapsNbLaps.Value; }
            set
            {
                lapsNbLaps.Value = value > 1 ? value : 1;
            }
        }

        /// <summary>
        /// Gets or sets the time limit in seconds in laps mode.
        /// </summary>
        public int LapsTimeLimit
        {
            get { return lapsTimeLimit.Value; }
            set
            {
                lapsTimeLimit.Value = value > 1 ? value : 1;
            }
        }

        /// <summary>
        /// Gets or sets the number of laps players have to drive in rounds mode.
        /// </summary>
        public int RoundsForcedLaps
        {
            get { return roundsForcedLaps.Value; }
            set
            {
                roundsForcedLaps.Value = value > 0 ? value : 0;
            }
        }

        /// <summary>
        /// Gets or sets the point limit in rounds mode.
        /// </summary>
        public int RoundsPointsLimit
        {
            get { return roundsPointsLimit.Value; }
            set
            {
                roundsPointsLimit.Value = value > 1 ? value : 1;
            }
        }

        /// <summary>
        /// Gets or sets whether to use the new rules in rounds mode or not.
        /// </summary>
        public bool RoundsUseNewRules
        {
            get { return roundsUseNewRules.Value; }
            set { roundsUseNewRules.Value = value; }
        }

        /// <summary>
        /// Gets or sets the maximum number of points in team mode.
        /// </summary>
        public int TeamMaxPoints
        {
            get { return teamMaxPoints.Value; }
            set
            {
                teamMaxPoints.Value = value > 1 ? value : 1;
            }
        }

        /// <summary>
        /// Gets or sets the points limit in team mode.
        /// </summary>
        public int TeamPointsLimit
        {
            get { return teamPointsLimit.Value; }
            set
            {
                teamPointsLimit.Value = value > 1 ? value : 1;
            }
        }

        /// <summary>
        /// Gets or sets whether to use the new rules in team mode or not.
        /// </summary>
        public bool TeamUseNewRules
        {
            get { return teamUseNewRules.Value; }
            set { teamUseNewRules.Value = value; }
        }

        /// <summary>
        /// Gets or sets the time limit in seconds in time attack mode.
        /// </summary>
        public int TimeAttackLimit
        {
            get { return timeAttackLimit.Value; }
            set
            {
                timeAttackLimit.Value = value > 1 ? value : 1;
            }
        }

        /// <summary>
        /// Gets or sets the syncronization time before start in time attack mode.
        /// </summary>
        public int TimeAttackSynchStartPeriod
        {
            get { return timeAttackSynchStartPeriod.Value; }
            set
            {
                timeAttackSynchStartPeriod.Value = value > 0 ? value : 0;
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.PassedInGameInfoStruct"/> without content (for parsing from Xml).
        /// </summary>
        public PassedInGameInfosStruct()
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Structs.PassedInGameInfoStruct"/> from the given game infos.
        /// </summary>
        /// <param name="gameInfo">The game infos to use for the creation.</param>
        public PassedInGameInfosStruct(ReturnedGameInfosStruct gameInfos)
        {
            ChatTime = gameInfos.ChatTime;
            FinishTimeout = gameInfos.FinishTimeout;
            GameMode = gameInfos.GameMode;
            LapsNbLaps = gameInfos.LapsNbLaps;
            LapsTimeLimit = gameInfos.LapsTimeLimit;
            RoundsForcedLaps = gameInfos.RoundsForcedLaps;
            RoundsPointsLimit = gameInfos.RoundsPointsLimit;
            RoundsUseNewRules = gameInfos.RoundsUseNewRules;
            TeamMaxPoints = gameInfos.TeamMaxPoints;
            TeamPointsLimit = gameInfos.TeamPointsLimit;
            TeamUseNewRules = gameInfos.TeamUseNewRules;
            TimeAttackLimit = gameInfos.TimeAttackLimit;
            TimeAttackSynchStartPeriod = gameInfos.TimeAttackSynchStartPeriod;
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("GameMode", gameMode.GenerateXml()),
                makeMemberElement("ChatTime", chatTime.GenerateXml()),
                makeMemberElement("RoundsPointsLimit", roundsPointsLimit.GenerateXml()),
                makeMemberElement("RoundsUseNewRules", roundsUseNewRules.GenerateXml()),
                makeMemberElement("RoundsForcedLaps", roundsForcedLaps.GenerateXml()),
                makeMemberElement("TimeAttackLimit", timeAttackLimit.GenerateXml()),
                makeMemberElement("TimeAttackSynchStartPeriod", timeAttackSynchStartPeriod.GenerateXml()),
                makeMemberElement("TeamPointsLimit", teamPointsLimit.GenerateXml()),
                makeMemberElement("TeamMaxPoints", teamMaxPoints.GenerateXml()),
                makeMemberElement("TeamUseNewRules", teamUseNewRules.GenerateXml()),
                makeMemberElement("LapsNbLaps", lapsNbLaps.GenerateXml()),
                makeMemberElement("LapsTimeLimit", lapsTimeLimit.GenerateXml()),
                makeMemberElement("FinishTimeout", finishTimeout.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override PassedInGameInfosStruct ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "GameMode":
                        gameMode.ParseXml(getValueContent(value, gameMode.ElementName));
                        break;

                    case "RoundsPointsLimit":
                        roundsPointsLimit.ParseXml(getValueContent(value, roundsPointsLimit.ElementName));
                        break;

                    case "RoundsUseNewRules":
                        roundsUseNewRules.ParseXml(getValueContent(value, roundsUseNewRules.ElementName));
                        break;

                    case "RoundsForcedLaps":
                        roundsForcedLaps.ParseXml(getValueContent(value, roundsForcedLaps.ElementName));
                        break;

                    case "TimeAttackLimit":
                        timeAttackLimit.ParseXml(getValueContent(value, timeAttackLimit.ElementName));
                        break;

                    case "TimeAttackSynchStartPeriod":
                        timeAttackSynchStartPeriod.ParseXml(getValueContent(value, timeAttackSynchStartPeriod.ElementName));
                        break;

                    case "TeamPointsLimit":
                        teamPointsLimit.ParseXml(getValueContent(value, teamPointsLimit.ElementName));
                        break;

                    case "TeamMaxPoints":
                        teamMaxPoints.ParseXml(getValueContent(value, teamMaxPoints.ElementName));
                        break;

                    case "TeamUseNewRules":
                        teamUseNewRules.ParseXml(getValueContent(value, teamUseNewRules.ElementName));
                        break;

                    case "LapsNbLaps":
                        lapsNbLaps.ParseXml(getValueContent(value, lapsNbLaps.ElementName));
                        break;

                    case "LapsTimeLimit":
                        lapsTimeLimit.ParseXml(getValueContent(value, lapsTimeLimit.ElementName));
                        break;

                    case "FinishTimeout":
                        finishTimeout.ParseXml(getValueContent(value, finishTimeout.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}