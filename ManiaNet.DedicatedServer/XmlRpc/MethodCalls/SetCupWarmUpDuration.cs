using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetCupWarmUpDuration method.
    /// </summary>
    public sealed class SetCupWarmUpDuration : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new warm up duration in number of rounds. 0 means no warm up.
        /// </summary>
        public int Duration
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetCupWarmUpDuration"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetCupWarmUpDuration"/> class wit the given duration.
        /// </summary>
        /// <param name="duration">The new warm up duration in number of rounds. 0 means no warm up.</param>
        public SetCupWarmUpDuration(int duration)
            : base(duration)
        { }
    }
}