using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the CheckMapForCurrentServerParams
    /// </summary>
    [UsedImplicitly]
    public sealed class CheckMapForCurrentServerParams : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filename of the map to check if it matches the server settings.
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
            get { return "CheckMapForCurrentServerParams"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.CheckMapForCurrentServerParams"/> class for the given filename.
        /// </summary>
        /// <param name="filename">The filename of the map to check if it matches the server settings.</param>
        public CheckMapForCurrentServerParams([NotNull] string filename)
            : base(filename)
        { }
    }
}