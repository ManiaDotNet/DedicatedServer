﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the EnableCallbacks method.
    /// </summary>
    public sealed class EnableCallbacks : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to enable the callbacks or not.
        /// </summary>
        public bool Enable
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "EnableCallbacks"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.EnableCallbacks"/> class with the given value for whether to enable them.
        /// </summary>
        /// <param name="enable">Whether to enable callbacks or not.</param>
        public EnableCallbacks(bool enable)
            : base(enable)
        { }
    }
}