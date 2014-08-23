using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the TrackMania.PlayerIncoherence method.
    /// </summary>
    [UsedImplicitly]
    public sealed class TrackManiaPlayerIncoherence : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "TrackMania.PlayerIncoherence"; }
        }

        /// <summary>
        /// Gets the Id of the player that drove through the checkpoint.
        /// </summary>
        [UsedImplicitly]
        public int PlayerId
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the login of the player that drove through the checkpoint.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string PlayerLogin
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.TrackManiaPlayerIncoherence"/> class with default content (for parsing from Xml).
        /// </summary>
        public TrackManiaPlayerIncoherence()
            : base(default(int), string.Empty)
        { }
    }
}