using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetLadderMode method call.
    /// </summary>
    public sealed class LadderModeStruct : I4CurrentAndNextValueStruct<LadderModeStruct>
    {
        /// <summary>
        /// Gets the current ladder mode. Compare to <see cref="ManiaNet.DedicatedServer.LadderModes"/> values.
        /// </summary>
        public override int CurrentValue
        {
            get { return currentValue.Value; }
        }

        /// <summary>
        /// Gets the next ladder mode.. Compare to <see cref="ManiaNet.DedicatedServer.LadderModes"/> values.
        /// </summary>
        public override int NextValue
        {
            get { return nextValue.Value; }
        }
    }
}