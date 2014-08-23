using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.PlayerAlliesChanged method.
    /// </summary>
    public sealed class ManiaPlanetPlayerAlliesChanged : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the login of the player who changed allies.
        /// </summary>
        [UsedImplicitly]
        public string Login
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.PlayerAlliesChanged"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetPlayerAlliesChanged"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetPlayerAlliesChanged()
            : base(string.Empty)
        { }
    }
}