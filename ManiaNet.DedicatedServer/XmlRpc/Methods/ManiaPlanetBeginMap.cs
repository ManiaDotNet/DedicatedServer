using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.BeginMap method.
    /// </summary>
    public sealed class ManiaPlanetBeginMap : XmlRpcMethodCall<XmlRpcStruct<MapInfoStruct>, MapInfoStruct, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets informations about the map.
        /// </summary>
        public MapInfoStruct Map
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.BeginMap"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetBeginMap"/> class with default values (for parsing from Xml).
        /// </summary>
        public ManiaPlanetBeginMap()
            : base(new MapInfoStruct())
        { }
    }
}