using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.PlayerDisconnect method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetPlayerDisconnect : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets a string describing why the client disconnected.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string DisconnectionReason
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets the login of the client that disconnected.
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
            get { return "ManiaPlanet.PlayerDisconnect"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetPlayerDisconnect"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetPlayerDisconnect()
            : base(string.Empty, string.Empty)
        { }
    }
}