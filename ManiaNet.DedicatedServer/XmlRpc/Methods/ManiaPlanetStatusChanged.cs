using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.StatusChanged method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetStatusChanged : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.StatusChanged"; }
        }

        /// <summary>
        /// Gets the new status code.
        /// </summary>
        [UsedImplicitly]
        public int StatusCode
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the new status name.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string StatusName
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetStatusChanged"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetStatusChanged()
            : base(default(int), string.Empty)
        { }
    }
}