﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the system.methodHelp method.
    /// </summary>
    public sealed class SystemMethodHelp : MethodCall<XmlRpcString, string, XmlRpcString, string>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "system.methodHelp"; }
        }

        /// <summary>
        /// Gets or sets the name of the method that the help is wanted for.
        /// </summary>
        public string TargetMethod
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SystemMethodHelp"/> class with the given target method name.
        /// </summary>
        /// <param name="targetMethod">The name of the method that the help is wanted for.</param>
        public SystemMethodHelp(string targetMethod)
            : base(targetMethod)
        { }
    }
}