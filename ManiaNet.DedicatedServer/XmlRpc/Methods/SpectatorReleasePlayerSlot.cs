using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SpectatorReleasePlayerSlot method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SpectatorReleasePlayerSlot : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of the spectator whose player spot will be freed.
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
            get { return "SpectatorReleasePlayerSlot"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SpectatorReleasePlayerSlot"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the spectator whose player spot will be freed.</param>
        public SpectatorReleasePlayerSlot([NotNull] string login)
            : base(login)
        { }
    }
}