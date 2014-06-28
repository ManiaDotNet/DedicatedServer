using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the TrackMania.PlayerFinish method.
    /// </summary>
    public sealed class TrackManiaPlayerFinish : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcString, string, XmlRpcI4, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "TrackMania.PlayerFinish"; }
        }

        /// <summary>
        /// Gets the Id of the player that drove through the checkpoint.
        /// </summary>
        public int PlayerId
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the login of the player that drove through the checkpoint.
        /// </summary>
        public string PlayerLogin
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets the time in milliseconds or score of the player that drove through the checkpoint.
        /// </summary>
        public int TimeOrScore
        {
            get { return param3.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.TrackManiaPlayerFinish"/> class with default content (for parsing from Xml).
        /// </summary>
        public TrackManiaPlayerFinish()
            : base(default(int), string.Empty, default(int))
        { }
    }
}