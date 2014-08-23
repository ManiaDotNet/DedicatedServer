using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.Echo method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetEcho : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the internal part of the Echo-call.
        /// Second parameter of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.Echo"/> method call.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Internal
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.Echo"; }
        }

        /// <summary>
        /// Gets the public part of the Echo-call.
        /// First parameter of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.Echo"/> method call.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Public
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetEcho"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetEcho()
            : base(string.Empty, string.Empty)
        { }
    }
}