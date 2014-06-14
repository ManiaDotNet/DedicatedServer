using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the EnableP2PUpload method.
    /// </summary>
    public sealed class EnableP2PUpload : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to enable P2P upload or not.
        /// </summary>
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
            get { return "EnableP2PUpload"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.EnableP2PUpload"/> class with the given value for whether or not to enable it.
        /// </summary>
        /// <param name="enable">Whether to enable P2P upload or not.</param>
        public EnableP2PUpload(bool enable)
            : base(enable)
        { }
    }
}