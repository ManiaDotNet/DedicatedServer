using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different referee modes.
    /// </summary>
    [UsedImplicitly]
    public static class RefereeModes
    {
        /// <summary>
        /// Mode in which all results will be validated.
        /// </summary>
        [UsedImplicitly]
        public const int ValidateAll = 1;

        /// <summary>
        /// Mode in which only the Top 3 results will be validated.
        /// </summary>
        [UsedImplicitly]
        public const int ValidateTop3 = 0;
    }
}