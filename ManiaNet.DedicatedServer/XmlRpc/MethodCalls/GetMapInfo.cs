using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetMapInfo method.
    /// </summary>
    public sealed class GetMapInfo : MethodCall<XmlRpcString, string, XmlRpcStruct<MapInfoStruct>, MapInfoStruct>
    {
        /// <summary>
        /// Gets or sets the filename of the map to get the infos for.
        /// </summary>
        public string Filename
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetMapInfo"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.GetMapInfo"/> class for the given filename.
        /// </summary>
        /// <param name="filename">The filename of the map to get the infos for.</param>
        public GetMapInfo(string filename)
            : base(filename)
        { }
    }
}