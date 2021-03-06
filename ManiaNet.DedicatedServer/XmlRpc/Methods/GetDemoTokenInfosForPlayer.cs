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
    /// Represents a call to the GetDemoTokenInfosForPlayer method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetDemoTokenInfosForPlayer : XmlRpcMethodCall<XmlRpcString, string, XmlRpcStruct<DemoTokenInfosStruct>, DemoTokenInfosStruct>
    {
        /// <summary>
        /// Gets or sets the login of the player for which the demo token infos will be returned.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetDemoTokenInfosForPlayer"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetDemoTokenInfosForPlayer"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the player for which the demo token infos will be returned.</param>
        public GetDemoTokenInfosForPlayer([NotNull] string login)
            : base(login)
        { }
    }
}