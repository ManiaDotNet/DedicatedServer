using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.PlayerInfoChanged method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetPlayerInfoChanged : XmlRpcMethodCall<XmlRpcStruct<PlayerInfoStruct>, PlayerInfoStruct, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.PlayerInfoChanged"; }
        }

        /// <summary>
        /// Gets the new Player info.
        /// </summary>
        [NotNull, UsedImplicitly]
        public PlayerInfoStruct PlayerInfo
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetPlayerInfoChanged"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetPlayerInfoChanged()
            : base(new PlayerInfoStruct())
        { }
    }
}