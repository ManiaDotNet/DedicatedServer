using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetTimeAttackSynchStartPeriod method.
    /// </summary>
    public sealed class GetTimeAttackSynchStartPeriod : XmlRpcMethodCall<XmlRpcStruct<CurrentAndNextValueStruct<XmlRpcI4, int>>, CurrentAndNextValueStruct<XmlRpcI4, int>>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetTimeAttackSynchStartPeriod"; }
        }
    }
}