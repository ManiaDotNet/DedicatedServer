using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ForcePlayerTeamId method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ForcePlayerTeamId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id of the player that will be moved.
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
            get { return "ForcePlayerTeamId"; }
        }

        /// <summary>
        /// Gets or sets the Id of the team that the player will be moved into. 0 or 1.
        /// </summary>
        [UsedImplicitly]
        public int TeamIdId
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ForcePlayerTeamId"/> class for the given login and team Id.
        /// </summary>
        /// <param name="id">The Id of the player that will be moved.</param>
        /// <param name="teamId">The Id of the team that the player will be moved into. 0 or 1.</param>
        public ForcePlayerTeamId(int id, int teamId)
            : base(id, teamId)
        { }
    }
}