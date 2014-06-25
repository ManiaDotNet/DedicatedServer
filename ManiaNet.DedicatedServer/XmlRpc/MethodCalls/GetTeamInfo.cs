using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetTeamInfo method.
    /// </summary>
    public sealed class GetTeamInfo : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcStruct<TeamInfoStruct>, TeamInfoStruct>
    {
        /// <summary>
        /// Gets or sets the Id of the team whose information will be returned. 0, 1, or 2.
        /// </summary>
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
            get { return "GetTeamInfo"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetTeamInfo"/> class with the given team Id.
        /// </summary>
        /// <param name="id">The Id of the team. 0, 1, or 2.</param>
        public GetTeamInfo(int id)
            : base(id)
        { }
    }
}