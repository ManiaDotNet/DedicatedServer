﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetClientInputsMaxLatency method. Only used by ShootMania.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetClientInputsMaxLatency : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the maximum time that the server should wait for inputs from the client before dropping data. 0 for auto adaption.
        /// </summary>
        [UsedImplicitly]
        public int MaxLatency
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetClientInputsMaxLatency"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetClientInputsMaxLatency"/> class with the given maximum latency.
        /// </summary>
        /// <param name="maxLatency">The maximum time that the server should wait for inputs from the client before dropping data. 0 for auto adaption.</param>
        public SetClientInputsMaxLatency(int maxLatency)
            : base(maxLatency)
        { }
    }
}