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
    /// Represents the struct passed to the SetGameInfos method call.
    /// </summary>
    public sealed class PassedInGameInfosStruct : BaseStruct
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
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("GameMode", gameMode),
                makeMemberElement("ChatTime", chatTime),
                makeMemberElement("RoundsPointsLimit", roundsPointsLimit),
                makeMemberElement("RoundsUseNewRules", roundsUseNewRules),
                makeMemberElement("RoundsForcedLaps", roundsForcedLaps),
                makeMemberElement("TimeAttackLimit", timeAttackLimit),
                makeMemberElement("TimeAttackSynchStartPeriod", timeAttackSynchStartPeriod),
                makeMemberElement("TeamPointsLimit", teamPointsLimit),
                makeMemberElement("TeamMaxPoints", teamMaxPoints),
                makeMemberElement("TeamUseNewRules", teamUseNewRules),
                makeMemberElement("LapsNbLaps", lapsNbLaps),
                makeMemberElement("LapsTimeLimit", lapsTimeLimit),
                makeMemberElement("FinishTimeout", finishTimeout));
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
                case "GameMode":
                    if (!gameMode.ParseXml(value))
                        return false;
                    break;

                case "RoundsPointsLimit":
                    if (!roundsPointsLimit.ParseXml(value))
                        return false;
                    break;

                case "RoundsUseNewRules":
                    if (!roundsUseNewRules.ParseXml(value))
                        return false;
                    break;

                case "RoundsForcedLaps":
                    if (!roundsForcedLaps.ParseXml(value))
                        return false;
                    break;

                case "TimeAttackLimit":
                    if (!timeAttackLimit.ParseXml(value))
                        return false;
                    break;

                case "TimeAttackSynchStartPeriod":
                    if (!timeAttackSynchStartPeriod.ParseXml(value))
                        return false;
                    break;

                case "TeamPointsLimit":
                    if (!teamPointsLimit.ParseXml(value))
                        return false;
                    break;

                case "TeamMaxPoints":
                    if (!teamMaxPoints.ParseXml(value))
                        return false;
                    break;

                case "TeamUseNewRules":
                    if (!teamUseNewRules.ParseXml(value))
                        return false;
                    break;

                case "LapsNbLaps":
                    if (!lapsNbLaps.ParseXml(value))
                        return false;
                    break;

                case "LapsTimeLimit":
                    if (!lapsTimeLimit.ParseXml(value))
                        return false;
                    break;

                case "FinishTimeout":
                    if (!finishTimeout.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}