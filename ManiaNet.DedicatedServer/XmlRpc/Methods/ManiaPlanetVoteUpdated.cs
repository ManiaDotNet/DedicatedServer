using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.VoteUpdated method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetVoteUpdated : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the command to be executed if the vote is successful.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string CmdName
        {
            get { return param3.Value; }
        }

        /// <summary>
        /// Gets the parameter for the command to be executed if the vote is successful.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string CmdParam
        {
            get { return param4.Value; }
        }

        /// <summary>
        /// Gets the login of the client that started the vote.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.VoteUpdated"; }
        }

        /// <summary>
        /// Gets the name of the vote's state. Compare to values from <see cref="ManiaNet.DedicatedServer.VoteStates"/>.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string StateName
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetVoteUpdated"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetVoteUpdated()
            : base(string.Empty, string.Empty, string.Empty, string.Empty)
        { }
    }
}