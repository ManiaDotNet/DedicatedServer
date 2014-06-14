using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetDemoTokenInfosForPlayer method.
    /// </summary>
    public sealed class GetDemoTokenInfosForPlayer : MethodCall<XmlRpcString, string, XmlRpcStruct<DemoTokenInfosStruct>, DemoTokenInfosStruct>
    {
        /// <summary>
        /// Gets or sets the login of the player for which the demo token infos will be returned.
        /// </summary>
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.GetDemoTokenInfosForPlayer"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the player for which the demo token infos will be returned.</param>
        public GetDemoTokenInfosForPlayer(string login)
            : base(login)
        { }
    }
}