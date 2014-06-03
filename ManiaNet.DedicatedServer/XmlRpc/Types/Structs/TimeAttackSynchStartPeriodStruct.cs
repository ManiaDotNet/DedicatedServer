using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetTimeAttackSynchStartPeriod method call.
    /// </summary>
    public sealed class TimeAttackSynchStartPeriodStruct : StringCurrentAndNextValueStruct<TimeAttackSynchStartPeriodStruct>
    {
        /// <summary>
        /// Gets the current synchronization time before start in time attack mode.
        /// </summary>
        public override string CurrentValue
        {
            get { return currentValue.Value; }
        }

        /// <summary>
        /// Gets the synchronization time before the start of the next map in time attack mode.
        /// </summary>
        public override string NextValue
        {
            get { return nextValue.Value; }
        }
    }
}