using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the LoadMatchSettings method.
    /// </summary>
    public sealed class LoadMatchSettings : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filename of the matchsettings file to load.
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
            get { return "LoadMatchSettings"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.LoadMatchSettings"/> class for the given filename.
        /// </summary>
        /// <param name="filename">The filename of the matchsettings file to load.</param>
        public LoadMatchSettings(string filename)
            : base(filename)
        { }
    }
}