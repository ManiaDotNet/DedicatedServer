using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the JoinServerInternet method.
    /// </summary>
    [UsedImplicitly]
    public sealed class JoinServerInternet : XmlRpcMethodCall<XmlRpcStruct<JoinServerStruct>, JoinServerStruct, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the information that will be used to join a server.
        /// </summary>
        [NotNull, UsedImplicitly]
        public JoinServerStruct JoinServer
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "JoinServerInternet"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.JoinServerInternet"/> class with the given join information.
        /// </summary>
        /// <param name="joinServer">The informations that will be used to join a server.</param>
        public JoinServerInternet([NotNull] JoinServerStruct joinServer)
            : base(joinServer)
        { }
    }
}