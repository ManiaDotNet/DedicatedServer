using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different spectator camera types.
    /// </summary>
    [UsedImplicitly]
    public static class SpectatorCameraTypes
    {
        /// <summary>
        /// The camera mode will be changed to follow.
        /// </summary>
        [UsedImplicitly]
        public const int Follow = 1;

        /// <summary>
        /// The camera type will be changed to free.
        /// </summary>
        [UsedImplicitly]
        public const int Free = 2;

        /// <summary>
        /// The camera type will be changed to replay.
        /// </summary>
        [UsedImplicitly]
        public const int Replay = 0;

        /// <summary>
        /// The camera type won't be changed.
        /// </summary>
        [UsedImplicitly]
        public const int Unchanged = -1;
    }
}