using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetPlayerInfo method.
    /// </summary>
    public sealed class GetPlayerInfo : MethodCall<XmlRpcString, string, XmlRpcStruct<PlayerInfoStruct>, PlayerInfoStruct>
    {
        /// <summary>
        /// Gets or sets the login of the player to get the info for.
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
            get { return "GetPlayerInfo"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.GetPlayerInfo"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the player to get the info for.</param>
        public GetPlayerInfo(string login)
            : base(login)
        { }
    }
}