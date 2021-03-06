﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SpectatorReleasePlayerSlotId method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SpectatorReleasePlayerSlotId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id of the spectator whose player spot will be freed.
        /// </summary>
        [UsedImplicitly]
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
            get { return "SpectatorReleasePlayerSlotId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SpectatorReleasePlayerSlotId"/> class for the given Id.
        /// </summary>
        /// <param name="id">The Id of the spectator whose player spot will be freed.</param>
        public SpectatorReleasePlayerSlotId(int id)
            : base(id)
        { }
    }
}