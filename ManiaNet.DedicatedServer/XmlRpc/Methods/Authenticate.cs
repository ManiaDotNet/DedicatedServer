using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the Authenticate method.
    /// </summary>
    [UsedImplicitly]
    public sealed class Authenticate : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login used for authentication.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "Authenticate"; }
        }

        /// <summary>
        /// Gets or sets the password used for authentication.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Password
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.Authenticate"/> class with the given login and password for authentication.
        /// </summary>
        /// <param name="login">The login used for authentication.</param>
        /// <param name="password">The password used for authentication.</param>
        public Authenticate([NotNull] string login, [NotNull] string password)
            : base(login, password)
        { }
    }
}