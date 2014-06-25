using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetUseNewRulesTeam method.
    /// </summary>
    public sealed class GetUseNewRulesTeam : XmlRpcMethodCall<XmlRpcStruct<CurrentAndNextValueStruct<XmlRpcBoolean, bool>>, CurrentAndNextValueStruct<XmlRpcBoolean, bool>>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetUseNewRulesTeam"; }
        }
    }
}