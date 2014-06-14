using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetMaxPlayers method.
    /// </summary>
    public sealed class GetMaxPlayers : MethodCall<XmlRpcInt, int>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetMaxPlayers"; }
        }
    }
}