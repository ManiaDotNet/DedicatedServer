using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetServerPasswordForSpectator method.
    /// </summary>
    public sealed class SetServerPasswordForSpectator : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetServerPasswordForSpectator"; }
        }

        /// <summary>
        /// Gets or sets the new spectator password for the server.
        /// </summary>
        public string Password
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetServerPasswordForSpectator"/> class with the given spectator password.
        /// </summary>
        /// <param name="password">The new spectator password for the server.</param>
        public SetServerPasswordForSpectator(string password)
            : base(password)
        { }
    }
}