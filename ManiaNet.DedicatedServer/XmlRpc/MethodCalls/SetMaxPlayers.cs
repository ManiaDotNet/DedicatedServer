using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetMaxPlayers method.
    /// </summary>
    public sealed class SetMaxPlayers : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetMaxPlayers"; }
        }

        /// <summary>
        /// Gets or sets the new maximum number of players.
        /// </summary>
        public int Players
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetMaxPlayers"/> class with the given number of players.
        /// </summary>
        /// <param name="players">The new maximum number of players.</param>
        public SetMaxPlayers(int players)
            : base(players)
        { }
    }
}