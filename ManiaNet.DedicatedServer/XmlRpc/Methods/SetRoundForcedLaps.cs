﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetRoundForcedLaps method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetRoundForcedLaps : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new number of laps in rounds mode. 0 means the number set by the map is used.
        /// </summary>
        [UsedImplicitly]
        public int Laps
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetRoundForcedLaps"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetRoundForcedLaps"/> class for the given number of laps.
        /// </summary>
        /// <param name="laps">The new number of laps in rounds mode. 0 means the number set by the map is used.</param>
        public SetRoundForcedLaps(int laps)
            : base(laps)
        { }
    }
}