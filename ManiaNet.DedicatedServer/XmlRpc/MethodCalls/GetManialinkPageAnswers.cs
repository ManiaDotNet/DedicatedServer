﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetManialinkPageAnswers method.
    /// </summary>
    public sealed class GetManialinkPageAnswers : MethodCall<XmlRpcArray<XmlRpcStruct<ManialinkPageAnswerStruct>, ManialinkPageAnswerStruct>, XmlRpcStruct<ManialinkPageAnswerStruct>[]>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetManialinkPageAnswers"; }
        }
    }
}