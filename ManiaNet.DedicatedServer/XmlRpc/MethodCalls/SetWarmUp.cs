using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetWarmUp method.
    /// </summary>
    public sealed class SetWarmUp : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetWarmUp"; }
        }

        /// <summary>
        /// Gets or sets whether the server will be in the warm up phase or not.
        /// </summary>
        public bool WarmUp
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetWarmUp"/> class with the given value for whether it will be in warm up or not.
        /// </summary>
        /// <param name="warmUp">Whether the server will be in the warm up phase or not.</param>
        public SetWarmUp(bool warmUp)
            : base(warmUp)
        { }
    }
}