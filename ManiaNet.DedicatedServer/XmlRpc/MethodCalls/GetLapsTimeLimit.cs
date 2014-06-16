using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetLapsTimeLimit method.
    /// </summary>
    public sealed class GetLapsTimeLimit : MethodCall<XmlRpcStruct<CurrentAndNextValueStruct<XmlRpcI4, int>>, CurrentAndNextValueStruct<XmlRpcI4, int>>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetLapsTimeLimit"; }
        }
    }
}