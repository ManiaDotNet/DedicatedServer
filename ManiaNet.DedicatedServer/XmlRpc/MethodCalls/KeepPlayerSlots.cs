using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the KeepPlayerSlots method.
    /// </summary>
    public sealed class KeepPlayerSlots : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
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
        public bool Value
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.KeepPlayerSlots"/> class with the given value.
        /// </summary>
        /// <param name="value">Whether the server still considers a player that switches to spectator as a player or not.</param>
        public KeepPlayerSlots(bool value)
            : base(value)
        { }
    }
}