﻿using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the ForceSpectatorId method.
    /// </summary>
    public sealed class ForceSpectatorId : MethodCall<XmlRpcInt, int, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id of the player that will be made a spectator.
        /// </summary>
        public int Id
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ForceSpectatorId"; }
        }

        /// <summary>
        /// Gets or sets the spectator mode the player will be forced into. Use values from <see cref="ManiaNet.DedicatedServer.SpectatorModes"/>.
        /// </summary>
        public int SpectatorMode
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.ForceSpectatorId"/> class for the given login and team Id.
        /// </summary>
        /// <param name="id">The Id of the player that will be made a spectator.</param>
        /// <param name="teamId">The spectator mode the player will be forced into. Use values from <see cref="ManiaNet.DedicatedServer.SpectatorModes"/>.</param>
        public ForceSpectatorId(int id, int teamId)
            : base(id, teamId)
        { }
    }
}