using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different server visability modes.
    /// </summary>
    [UsedImplicitly]
    public static class VisibilityModes
    {
        /// <summary>
        /// The Server is hidden from everyone.
        /// </summary>
        [UsedImplicitly]
        public const int AlwaysHidden = 1;

        /// <summary>
        /// The Server is hidden from nations. (Seems pointless with the new ManiaPlanet...)
        /// </summary>
        [UsedImplicitly]
        public const int HiddenFromNations = 2;

        /// <summary>
        /// The Server is visible to everyone.
        /// </summary>
        [UsedImplicitly]
        public const int Visible = 0;
    }
}