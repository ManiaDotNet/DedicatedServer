using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetClientInputsMaxLatency method. Only used by ShootMania.
    /// </summary>
    public sealed class GetClientInputsMaxLatency : MethodCall<XmlRpcI4, int>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetClientInputsMaxLatency"; }
        }
    }
}