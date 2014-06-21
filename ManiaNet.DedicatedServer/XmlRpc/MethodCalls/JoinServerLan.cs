using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the JoinServerLan method.
    /// </summary>
    public sealed class JoinServerLan : MethodCall<XmlRpcStruct<JoinServerStruct>, JoinServerStruct, XmlRpcBoolean, bool>
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
            get { return "JoinServerLan"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.JoinServerLan"/> class with the given join information.
        /// </summary>
        /// <param name="joinServer">The informations that will be used to join a server.</param>
        public JoinServerLan(JoinServerStruct joinServer)
            : base(joinServer)
        { }
    }
}