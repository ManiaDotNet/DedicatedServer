using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SpectatorReleasePlayerSlot method.
    /// </summary>
    public sealed class SpectatorReleasePlayerSlot : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of the spectator whose player spot will be freed.
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
            get { return "SpectatorReleasePlayerSlot"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SpectatorReleasePlayerSlot"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the spectator whose player spot will be freed.</param>
        public SpectatorReleasePlayerSlot(string login)
            : base(login)
        { }
    }
}