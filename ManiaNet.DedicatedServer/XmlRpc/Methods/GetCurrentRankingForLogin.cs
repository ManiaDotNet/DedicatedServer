using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetCurrentRankingForLogin method.
    /// </summary>
    public sealed class GetCurrentRankingForLogin : XmlRpcMethodCall<XmlRpcString, string, XmlRpcStruct<RankingStruct>, RankingStruct>
    {
        /// <summary>
        /// Gets or sets the login of the player to get the ranking for.
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
            get { return "GetCurrentRankingForLogin"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetCurrentRankingForLogin"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the player to get the ranking for.</param>
        public GetCurrentRankingForLogin(string login)
            : base(login)
        { }
    }
}