using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetCupWarmUpDuration method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetCupWarmUpDuration : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new warm up duration in number of rounds. 0 means no warm up.
        /// </summary>
        [UsedImplicitly]
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetCupWarmUpDuration"/> class wit the given duration.
        /// </summary>
        /// <param name="duration">The new warm up duration in number of rounds. 0 means no warm up.</param>
        public SetCupWarmUpDuration(int duration)
            : base(duration)
        { }
    }
}