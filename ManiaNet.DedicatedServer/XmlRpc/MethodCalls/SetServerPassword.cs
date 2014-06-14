using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetServerPassword method.
    /// </summary>
    public sealed class SetServerPassword : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetServerPassword"; }
        }

        /// <summary>
        /// Gets or sets the new password for the server.
        /// </summary>
        public string Password
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetServerPassword"/> class with the given password.
        /// </summary>
        /// <param name="password">The new password for the server.</param>
        public SetServerPassword(string password)
            : base(password)
        { }
    }
}