using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the JoinServerInternet method.
    /// </summary>
    public sealed class JoinServerInternet : MethodCall<XmlRpcStruct<JoinServerStruct>, JoinServerStruct, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the information that will be used to join a server.
        /// </summary>
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.JoinServerInternet"/> class with the given join information.
        /// </summary>
        /// <param name="joinServer">The informations that will be used to join a server.</param>
        public JoinServerInternet(JoinServerStruct joinServer)
            : base(joinServer)
        { }
    }
}