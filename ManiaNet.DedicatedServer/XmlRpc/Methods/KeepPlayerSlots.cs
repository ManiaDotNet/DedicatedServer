﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the KeepPlayerSlots method.
    /// </summary>
    [UsedImplicitly]
    public sealed class KeepPlayerSlots : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "KeepPlayerSlots"; }
        }

        /// <summary>
        /// Gets or sets whether the server still considers a player that switches to spectator as a player or not.
        /// </summary>
        [UsedImplicitly]
        public bool Value
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.KeepPlayerSlots"/> class with the given value.
        /// </summary>
        /// <param name="value">Whether the server still considers a player that switches to spectator as a player or not.</param>
        public KeepPlayerSlots(bool value)
            : base(value)
        { }
    }
}