using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetCallVoteRatio method.
    /// </summary>
    public sealed class GetCallVoteRatio : MethodCall<XmlRpcDouble, double>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetCallVoteRatio"; }
        }
    }
}