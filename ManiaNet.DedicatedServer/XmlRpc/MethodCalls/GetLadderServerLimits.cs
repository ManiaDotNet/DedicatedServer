using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetLadderServerLimits method.
    /// </summary>
    public sealed class GetLadderServerLimits : MethodCall<XmlRpcStruct<LadderServerLimitsStruct>, LadderServerLimitsStruct>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetLadderServerLimits"; }
        }
    }
}