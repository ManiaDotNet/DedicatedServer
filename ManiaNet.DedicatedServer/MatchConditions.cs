using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different match conditions.
    /// </summary>
    [UsedImplicitly]
    public static class MatchConditions
    {
        /// <summary>
        /// Match condition when the map is being changed.
        /// </summary>
        [UsedImplicitly]
        public const string ChangeMap = "ChangeMap";

        /// <summary>
        /// Match condition when the map is finished.
        /// </summary>
        [UsedImplicitly]
        public const string Finished = "Finished";

        /// <summary>
        /// Match condition when the map is being played.
        /// </summary>
        [UsedImplicitly]
        public const string Playing = "Playing";
    }
}