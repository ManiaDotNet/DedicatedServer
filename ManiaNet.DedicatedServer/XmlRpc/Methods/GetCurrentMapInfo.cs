﻿using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetCurrentMapInfo method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetCurrentMapInfo : XmlRpcMethodCall<XmlRpcStruct<MapInfoStruct>, MapInfoStruct>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetCurrentMapInfo"; }
        }
    }
}