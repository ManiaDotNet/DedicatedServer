﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetChatLines method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetChatLines : XmlRpcMethodCall<XmlRpcArray<XmlRpcString, string>, XmlRpcString[]>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetChatLines"; }
        }
    }
}