using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different spectator camera types.
    /// </summary>
    public static class SpectatorCameraTypes
    {
        public const int Follow = 1;
        public const int Free = 2;
        public const int Replay = 0;
        public const int Unchanged = -1;
    }
}