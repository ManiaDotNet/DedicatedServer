﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetServerOptions method.
    /// </summary>
    public sealed class SetServerOptions : MethodCall<XmlRpcStruct<PassedInServerOptionsStruct>, PassedInServerOptionsStruct, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetServerOptions"; }
        }

        /// <summary>
        /// Gets or sets the new server options.
        /// </summary>
        public PassedInServerOptionsStruct ServerOptions
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetServerOptions"/> class with the given server options.
        /// </summary>
        /// <param name="serverOptions">The new server options.</param>
        public SetServerOptions(PassedInServerOptionsStruct serverOptions)
            : base(serverOptions)
        { }
    }
}