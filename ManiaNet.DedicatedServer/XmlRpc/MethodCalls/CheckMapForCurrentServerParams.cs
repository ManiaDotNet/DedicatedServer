using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the CheckMapForCurrentServerParams
    /// </summary>
    public sealed class CheckMapForCurrentServerParams : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filename of the map to check if it matches the server settings.
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
            get { return "CheckMapForCurrentServerParams"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.CheckMapForCurrentServerParams"/> class for the given filename.
        /// </summary>
        /// <param name="filename">The filename of the map to check if it matches the server settings.</param>
        public CheckMapForCurrentServerParams(string filename)
            : base(filename)
        { }
    }
}