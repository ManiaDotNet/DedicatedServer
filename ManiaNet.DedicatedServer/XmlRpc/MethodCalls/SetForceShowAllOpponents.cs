using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetForceShowAllOpponents method.
    /// </summary>
    public sealed class SetForceShowAllOpponents : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetForceShowAllOpponents"; }
        }

        /// <summary>
        /// Gets or sets the number of opponents that will be shown for every player.
        /// 0 means none will be forced, 1 means ALL opponents will be shown.
        /// </summary>
        public int Opponents
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetForceShowAllOpponents"/> class with the given number of opponents.
        /// </summary>
        /// <param name="opponents">The number of opponents that will be shown for every player.
        /// 0 means none will be forced, 1 means ALL opponents will be shown.</param>
        public SetForceShowAllOpponents(int opponents)
            : base(opponents)
        { }
    }
}