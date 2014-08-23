using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different manual flow control modes.
    /// </summary>
    [UsedImplicitly]
    public static class ManualFlowControlModes
    {
        /// <summary>
        /// Value for disabled manual flow control.
        /// </summary>
        [UsedImplicitly]
        public const int Disabled = 0;

        /// <summary>
        /// Value for manual flow control enabled by a different XmlRpc client.
        /// </summary>
        [UsedImplicitly]
        public const int EnabledByOther = 2;

        /// <summary>
        /// Value for manual flow control enabled by this XmlRpc client.
        /// </summary>
        [UsedImplicitly]
        public const int EnabledByThis = 1;
    }
}