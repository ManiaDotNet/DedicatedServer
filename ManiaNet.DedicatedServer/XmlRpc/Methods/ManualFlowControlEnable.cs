using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ManualFlowControlEnable method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManualFlowControlEnable : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether manual flow control will be enabled or not.
        /// </summary>
        [UsedImplicitly]
        public bool Enable
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManualFlowControlEnable"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManualFlowControlEnable"/> class with the given value for whether to enable it.
        /// </summary>
        /// <param name="enable">Whether manual flow control will be enabled or not.</param>
        public ManualFlowControlEnable(bool enable)
            : base(enable)
        { }
    }
}