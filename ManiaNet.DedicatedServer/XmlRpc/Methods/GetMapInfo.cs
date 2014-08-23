using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetMapInfo method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetMapInfo : XmlRpcMethodCall<XmlRpcString, string, XmlRpcStruct<MapInfoStruct>, MapInfoStruct>
    {
        /// <summary>
        /// Gets or sets the filename of the map to get the infos for.
        /// </summary>
        [NotNull, UsedImplicitly]
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetMapInfo"/> class for the given filename.
        /// </summary>
        /// <param name="filename">The filename of the map to get the infos for.</param>
        public GetMapInfo([NotNull] string filename)
            : base(filename)
        { }
    }
}