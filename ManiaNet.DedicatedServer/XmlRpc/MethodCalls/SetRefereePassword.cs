using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetRefereePassword method.
    /// </summary>
    public sealed class SetRefereePassword : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetRefereePassword"; }
        }

        /// <summary>
        /// Gets or sets the new referee password.
        /// </summary>
        public string Password
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetRefereePassword"/> class for the given password.
        /// </summary>
        /// <param name="password">The new referee password.</param>
        public SetRefereePassword(string password)
            : base(password)
        { }
    }
}