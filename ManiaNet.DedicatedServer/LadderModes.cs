using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different ladder modes.
    /// </summary>
    public static class LadderModes
    {
        /// <summary>
        /// Ladder mode is active.
        /// </summary>
        [UsedImplicitly]
        public const int Forced = 1;

        /// <summary>
        /// Ladder mode is inactive.
        /// </summary>
        [UsedImplicitly]
        public const int Inactive = 0;
    }
}