using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the DisableHorns method.
    /// </summary>
    public sealed class DisableHorns : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to disable horns or not.
        /// </summary>
        public bool Disable
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "DisableHorns"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.DisableHorns"/> class with the given value for whether to disable them or not.
        /// </summary>
        /// <param name="disable">Whether to disable horns or not.</param>
        public DisableHorns(bool disable)
            : base(disable)
        { }
    }
}