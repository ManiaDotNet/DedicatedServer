using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the ForcePlayerTeam method.
    /// </summary>
    public sealed class ForcePlayerTeam : MethodCall<XmlRpcString, string, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of the player that will be moved.
        /// </summary>
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ForcePlayerTeam"; }
        }

        /// <summary>
        /// Gets or sets the Id of the team that the player will be moved into. 0 or 1.
        /// </summary>
        public int TeamId
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.ForcePlayerTeam"/> class for the given login and team Id.
        /// </summary>
        /// <param name="login">The login of the player that will be moved.</param>
        /// <param name="teamId">The Id of the team that the player will be moved into. 0 or 1.</param>
        public ForcePlayerTeam(string login, int teamId)
            : base(login, teamId)
        { }
    }
}