using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetServerName method.
    /// </summary>
    public sealed class SetServerName : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetServerName"; }
        }

        /// <summary>
        /// Gets or sets the new name of the server.
        /// </summary>
        public string Name
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetServerName"/> class with the given server name.
        /// </summary>
        /// <param name="name">The new name of the server.</param>
        public SetServerName(string name)
            : base(name)
        { }
    }
}