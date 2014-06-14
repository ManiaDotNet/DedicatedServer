using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the AllowMapDownload method.
    /// </summary>
    public sealed class AllowMapDownload : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to allow map downloads or not.
        /// </summary>
        public bool Allow
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "AllowMapDownload"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.AllowMapDownload"/> class with the given value for whether to allow it or not.
        /// </summary>
        /// <param name="allow">Whether to allow map downloads or not.</param>
        public AllowMapDownload(bool allow)
            : base(allow)
        { }
    }
}