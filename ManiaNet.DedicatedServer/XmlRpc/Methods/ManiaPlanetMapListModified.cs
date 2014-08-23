using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.MapListModified method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetMapListModified : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcI4, int, XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the current map's index in the list.
        /// </summary>
        [UsedImplicitly]
        public int CurrentMapIndex
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets whether the list was modifed or not.
        /// </summary>
        [UsedImplicitly]
        public bool IsListModified
        {
            get { return param3.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.MapListModified"; }
        }

        /// <summary>
        /// Gets the next map's index in the list.
        /// </summary>
        [UsedImplicitly]
        public int NextMapIndex
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetMapListModified"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetMapListModified()
            : base(default(int), default(int), default(bool))
        { }
    }
}