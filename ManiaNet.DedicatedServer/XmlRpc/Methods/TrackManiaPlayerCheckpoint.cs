using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the TrackMania.PlayerCheckpoint method.
    /// </summary>
    public sealed class TrackManiaPlayerCheckpoint : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcString, string, XmlRpcI4, int, XmlRpcI4, int, XmlRpcI4, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the index of the checkpoint that the player drove through. I.e. how many checkpoints the player drove through.
        /// </summary>
        public int CheckpointIndex
        {
            get { return param5.Value; }
        }

        /// <summary>
        /// Gets the lap that the player that drove through the checkpoint is on.
        /// </summary>
        public int CurrentLap
        {
            get { return param4.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "TrackMania.PlayerCheckpoint"; }
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.TrackManiaPlayerCheckpoint"/> class with default content (for parsing from Xml).
        /// </summary>
        public TrackManiaPlayerCheckpoint()
            : base(default(int), string.Empty, default(int), default(int), default(int))
        { }
    }
}