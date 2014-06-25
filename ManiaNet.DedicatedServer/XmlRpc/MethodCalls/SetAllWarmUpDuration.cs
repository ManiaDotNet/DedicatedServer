using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetAllWarmUpDuration method.
    /// </summary>
    public sealed class SetAllWarmUpDuration : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new duration of the warm up phase for all modes.
        /// Number of rounds in rounds and laps mode, number of times the gold medal time in other modes.
        /// 0 means no warm up phase.
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
            get { return "SetAllWarmUpDuration"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetAllWarmUpDuration"/> class for the given duration.
        /// </summary>
        /// <param name="duration">The new duration of the warm up phase for all modes.
        /// Number of rounds in rounds and laps mode, number of times the gold medal time in other modes.
        /// 0 means no warm up phase.</param>
        public SetAllWarmUpDuration(int duration)
            : base(duration)
        { }
    }
}