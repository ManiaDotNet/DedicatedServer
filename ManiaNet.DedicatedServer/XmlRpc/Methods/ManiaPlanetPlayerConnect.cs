using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.PlayerConnect method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetPlayerConnect : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets whether the client connected as spectator or not.
        /// </summary>
        [UsedImplicitly]
        public bool IsSpectator
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets the login of the client that connected.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.PlayerConnect"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetPlayerConnect"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetPlayerConnect()
            : base(string.Empty, default(bool))
        { }
    }
}