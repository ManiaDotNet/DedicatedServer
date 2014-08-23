using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetServerPassword method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetServerPassword : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
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
        [NotNull, UsedImplicitly]
        public string Password
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetServerPassword"/> class with the given password.
        /// </summary>
        /// <param name="password">The new password for the server.</param>
        public SetServerPassword([NotNull] string password)
            : base(password)
        { }
    }
}