using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different game modes.
    /// </summary>
    public static class GameModes
    {
        /// <summary>
        /// Cup mode.
        /// </summary>
        [UsedImplicitly]
        public const int Cup = 5;

        /// <summary>
        /// Laps mode.
        /// </summary>
        [UsedImplicitly]
        public const int Laps = 4;

        /// <summary>
        /// Rounds mode.
        /// </summary>
        [UsedImplicitly]
        public const int Rounds = 1;

        /// <summary>
        /// Script mode.
        /// </summary>
        [UsedImplicitly]
        public const int Script = 0;

        /// <summary>
        /// Stunts mode.
        /// </summary>
        [UsedImplicitly]
        public const int Stunts = 6;

        /// <summary>
        /// Team mode.
        /// </summary>
        [UsedImplicitly]
        public const int Team = 3;

        /// <summary>
        /// TimeAttack mode.
        /// </summary>
        [UsedImplicitly]
        public const int TimeAttack = 2;
    }
}