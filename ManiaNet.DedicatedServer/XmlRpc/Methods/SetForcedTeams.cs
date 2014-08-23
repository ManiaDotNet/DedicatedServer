using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetForcedTeams method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetForcedTeams : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether players are put into teams by the server, or can choose for themselves.
        /// </summary>
        [UsedImplicitly]
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetForcedTeams"/> class with the given value for whether they are forced.
        /// </summary>
        /// <param name="forced">Whether players are put into teams by the server, or can choose for themselves.</param>
        public SetForcedTeams(bool forced)
            : base(forced)
        { }
    }
}