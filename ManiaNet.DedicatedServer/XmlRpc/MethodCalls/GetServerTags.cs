using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetServerTags method.
    /// </summary>
    public sealed class GetServerTags : MethodCall<XmlRpcArray<XmlRpcStruct<ServerTagStruct>, ServerTagStruct>, XmlRpcStruct<ServerTagStruct>[]>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetServerTags"; }
        }
    }
}