using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different manual flow control modes.
    /// </summary>
    public static class ManualFlowControlModes
    {
        public const int Disabled = 0;
        public const int EnabledByOther = 2;
        public const int EnabledByThis = 1;
    }
}