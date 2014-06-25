using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the DisconnectFakePlayer method.
    /// </summary>
    public sealed class DisconnectFakePlayer : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of the fake player that's going to be disconnected. * for all fake players.
        /// </summary>
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
            get { return "DisconnectFakePlayer"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.DisconnectFakePlayer"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the fake player that's going to be disconnected. * for all fake players.</param>
        public DisconnectFakePlayer(string login)
            : base(login)
        { }
    }
}