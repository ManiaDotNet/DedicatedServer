using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetWarmUp method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetWarmUp : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
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
        [UsedImplicitly]
        public bool WarmUp
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetWarmUp"/> class with the given value for whether it will be in warm up or not.
        /// </summary>
        /// <param name="warmUp">Whether the server will be in the warm up phase or not.</param>
        public SetWarmUp(bool warmUp)
            : base(warmUp)
        { }
    }
}