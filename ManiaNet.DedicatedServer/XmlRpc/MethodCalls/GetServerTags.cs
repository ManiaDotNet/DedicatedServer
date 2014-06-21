using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

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