using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetApiVersion method.
    /// </summary>
    public sealed class SetApiVersion : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Api Version used for callbacks. Use values from <see cref="ManiaNet.DedicatedServer.ApiVersions"/>.
        /// </summary>
        public string ApiVersion
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetApiVersion"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetApiVersion"/> class with the given Api version.
        /// </summary>
        /// <param name="apiVersion">The Api Version used for callbacks. Use those in <see cref="ManiaNet.DedicatedServer.ApiVersions"/>.</param>
        public SetApiVersion(string apiVersion)
            : base(apiVersion)
        { }
    }
}