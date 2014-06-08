﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the system.methodSignature method.
    /// </summary>
    public sealed class SystemMethodSignature : MethodCall<XmlRpcString, string, XmlRpcArray<XmlRpcArray<XmlRpcString, string>, XmlRpcString[]>, XmlRpcArray<XmlRpcString, string>[]>
    {
        /// <summary>
        /// Gets or sets the login used for authentication.
        /// </summary>
        public override string MethodName
        {
            get { return "system.methodSignature"; }
        }

        /// <summary>
        /// Gets or sets the name of the method that the signatures are wanted for.
        /// </summary>
        public string TargetMethod
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SystemMethodSignature"/> class with the given target method name.
        /// </summary>
        /// <param name="targetMethod">The name of the method that the signatures are wanted for.</param>
        public SystemMethodSignature(string targetMethod)
            : base(targetMethod)
        {
            TargetMethod = targetMethod;
        }
    }
}