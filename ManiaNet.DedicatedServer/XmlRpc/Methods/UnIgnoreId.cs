﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the UnIgnoreIdId method.
    /// </summary>
    [UsedImplicitly]
    public sealed class UnIgnoreId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id that will be UnIgnoreIdd.
        /// </summary>
        [UsedImplicitly]
        public int Id
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "UnIgnoreId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.UnIgnoreId"/> class for the given Id.
        /// </summary>
        /// <param name="id">The Id that will be UnIgnoreIdd.</param>
        public UnIgnoreId(int id)
            : base(id)
        { }
    }
}