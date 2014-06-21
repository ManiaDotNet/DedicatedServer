using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetForcedTeams method.
    /// </summary>
    public sealed class SetForcedTeams : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether players are put into teams by the server, or can choose for themselves.
        /// </summary>
        public bool Forced
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetForcedTeams"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetForcedTeams"/> class with the given value for whether they are forced.
        /// </summary>
        /// <param name="forced">Whether players are put into teams by the server, or can choose for themselves.</param>
        public SetForcedTeams(bool forced)
            : base(forced)
        { }
    }
}