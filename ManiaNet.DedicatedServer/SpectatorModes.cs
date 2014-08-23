using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different spectator modes.
    /// </summary>
    [UsedImplicitly]
    public static class SpectatorModes
    {
        /// <summary>
        /// The user is forced to be Player.
        /// </summary>
        [UsedImplicitly]
        public const int Player = 2;

        /// <summary>
        /// The user is forced to be Spectator.
        /// </summary>
        [UsedImplicitly]
        public const int Spectator = 1;

        /// <summary>
        /// The Spectator can select the mode.
        /// </summary>
        [UsedImplicitly]
        public const int SpectatorSelectable = 3;

        /// <summary>
        /// The user can select the mode.
        /// </summary>
        [UsedImplicitly]
        public const int UserSelectable = 0;
    }
}