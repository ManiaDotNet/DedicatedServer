using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetClientInputsMaxLatency method. Only used by ShootMania.
    /// </summary>
    public sealed class SetClientInputsMaxLatency : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the maximum time that the server should wait for inputs from the client before dropping data. 0 for auto adaption.
        /// </summary>
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetClientMaxLatency"/> class with the given maximum latency.
        /// </summary>
        /// <param name="maxLatency">The maximum time that the server should wait for inputs from the client before dropping data. 0 for auto adaption.</param>
        public SetClientInputsMaxLatency(int maxLatency)
            : base(maxLatency)
        { }
    }
}