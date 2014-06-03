using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned from the GetCurrentGameInfo and GetNextGameInfo method calls.
    /// </summary>
    public sealed class ReturnedGameInfosStruct : BaseStruct<ReturnedGameInfosStruct>
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
        /// Backing field for the NbChallenge property.
        /// </summary>
        private XmlRpcI4 nbChallenge = new XmlRpcI4();

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
            return new XElement(XName.Get(ElementName),
                makeMemberElement("GameMode", gameMode.GenerateXml()),
                makeMemberElement("ChatTime", chatTime.GenerateXml()),
                makeMemberElement("NbChallenge", nbChallenge.GenerateXml()),
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
        public override ReturnedGameInfosStruct ParseXml(XElement xElement)
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

                    case "ChatTime":
                        chatTime.ParseXml(getValueContent(value, chatTime.ElementName));
                        break;

                    case "NbChallenge":
                        nbChallenge.ParseXml(getValueContent(value, nbChallenge.ElementName));
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