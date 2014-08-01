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
    /// Represents the struct returned from the GetCurrentGameInfo and GetNextGameInfo method calls.
    /// </summary>
    public sealed class ReturnedGameInfosStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the ChatTime property.
        /// </summary>
        private readonly XmlRpcI4 chatTime = new XmlRpcI4();

        /// <summary>
        /// Backing field for the FinishTimeout property.
        /// </summary>
        private readonly XmlRpcI4 finishTimeout = new XmlRpcI4();

        /// <summary>
        /// Backing field for the GameMode property.
        /// </summary>
        private readonly XmlRpcI4 gameMode = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LapsNbLaps property.
        /// </summary>
        private readonly XmlRpcI4 lapsNbLaps = new XmlRpcI4();

        /// <summary>
        /// Backing field for the LapsTimeLimit property.
        /// </summary>
        private readonly XmlRpcI4 lapsTimeLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the NbChallenge property.
        /// </summary>
        private readonly XmlRpcI4 nbChallenge = new XmlRpcI4();

        /// <summary>
        /// Backing field for the RoundsForcedLaps property.
        /// </summary>
        private readonly XmlRpcI4 roundsForcedLaps = new XmlRpcI4();

        /// <summary>
        /// Backing field for the RoundsPointsLimit property.
        /// </summary>
        private readonly XmlRpcI4 roundsPointsLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the RoundsUseNewRules property.
        /// </summary>
        private readonly XmlRpcBoolean roundsUseNewRules = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the TeamMaxPoints property.
        /// </summary>
        private readonly XmlRpcI4 teamMaxPoints = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TeamPointsLimit property.
        /// </summary>
        private readonly XmlRpcI4 teamPointsLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TeamUseNewRules property.
        /// </summary>
        private readonly XmlRpcBoolean teamUseNewRules = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the TimeAttackLimit property.
        /// </summary>
        private readonly XmlRpcI4 timeAttackLimit = new XmlRpcI4();

        /// <summary>
        /// Backing field for the TimeAttackSynchStartPeriod property.
        /// </summary>
        private readonly XmlRpcI4 timeAttackSynchStartPeriod = new XmlRpcI4();

        /// <summary>
        /// Gets the chat time at the end of the map in milliseconds.
        /// </summary>
        public int ChatTime
        {
            get { return chatTime.Value; }
        }

        /// <summary>
        /// Gets the finish timeout in seconds.
        /// </summary>
        public int FinishTimeout
        {
            get { return finishTimeout.Value; }
        }

        /// <summary>
        /// Gets the game mode. Compare to <see cref="ManiaNet.DedicatedServer.GameModes"/> values.
        /// </summary>
        public int GameMode
        {
            get { return gameMode.Value; }
        }

        /// <summary>
        /// Gets the number of laps players have to drive in laps mode.
        /// </summary>
        public int LapsNbLaps
        {
            get { return lapsNbLaps.Value; }
        }

        /// <summary>
        /// Gets the time limit in seconds in laps mode.
        /// </summary>
        public int LapsTimeLimit
        {
            get { return lapsTimeLimit.Value; }
        }

        /// <summary>
        /// Gets the number of challenges on the server.
        /// </summary>
        public int NbChallenge
        {
            get { return nbChallenge.Value; }
        }

        /// <summary>
        /// Gets the number of laps players have to drive in rounds mode.
        /// </summary>
        public int RoundsForcedLaps
        {
            get { return roundsForcedLaps.Value; }
        }

        /// <summary>
        /// Gets the point limit in rounds mode.
        /// </summary>
        public int RoundsPointsLimit
        {
            get { return roundsPointsLimit.Value; }
        }

        /// <summary>
        /// Gets whether to use the new rules in rounds mode or not.
        /// </summary>
        public bool RoundsUseNewRules
        {
            get { return roundsUseNewRules.Value; }
        }

        /// <summary>
        /// Gets the maximum number of points in team mode.
        /// </summary>
        public int TeamMaxPoints
        {
            get { return teamMaxPoints.Value; }
        }

        /// <summary>
        /// Gets the points limit in team mode.
        /// </summary>
        public int TeamPointsLimit
        {
            get { return teamPointsLimit.Value; }
        }

        /// <summary>
        /// Gets whether to use the new rules in team mode or not.
        /// </summary>
        public bool TeamUseNewRules
        {
            get { return teamUseNewRules.Value; }
        }

        /// <summary>
        /// Gets the time limit in seconds in time attack mode.
        /// </summary>
        public int TimeAttackLimit
        {
            get { return timeAttackLimit.Value; }
        }

        /// <summary>
        /// Gets the syncronization time before start in time attack mode.
        /// </summary>
        public int TimeAttackSynchStartPeriod
        {
            get { return timeAttackSynchStartPeriod.Value; }
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
                makeMemberElement("NbChallenge", nbChallenge),
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

                case "ChatTime":
                    if (!chatTime.ParseXml(value))
                        return false;
                    break;

                case "NbChallenge":
                    if (!nbChallenge.ParseXml(value))
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