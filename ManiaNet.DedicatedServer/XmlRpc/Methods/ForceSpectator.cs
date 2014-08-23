using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ForceSpectator method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ForceSpectator : XmlRpcMethodCall<XmlRpcString, string, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of the player that will be made a spectator.
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
            get { return "ForceSpectator"; }
        }

        /// <summary>
        /// Gets or sets the spectator mode the player will be forced into. Use values from <see cref="ManiaNet.DedicatedServer.SpectatorModes"/>.
        /// </summary>
        [UsedImplicitly]
        public int SpectatorMode
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ForceSpectator"/> class for the given login and team Id.
        /// </summary>
        /// <param name="login">The login of the player that will be made a spectator.</param>
        /// <param name="teamId">The spectator mode the player will be forced into. Use values from <see cref="ManiaNet.DedicatedServer.SpectatorModes"/>.</param>
        public ForceSpectator([NotNull] string login, int teamId)
            : base(login, teamId)
        { }
    }
}