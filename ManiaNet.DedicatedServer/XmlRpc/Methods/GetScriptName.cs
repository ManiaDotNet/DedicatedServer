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
    /// Represents a call to the GetScriptName method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetScriptName : XmlRpcMethodCall<XmlRpcStruct<CurrentAndNextValueStruct<XmlRpcString, string>>, CurrentAndNextValueStruct<XmlRpcString, string>>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetScriptName"; }
        }
    }
}