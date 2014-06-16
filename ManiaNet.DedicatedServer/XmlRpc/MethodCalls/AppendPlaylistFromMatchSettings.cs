using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the AppendPlaylistFromMatchSettings method.
    /// </summary>
    public sealed class AppendPlaylistFromMatchSettings : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filename of the matchsettings file to append the tracks of at the end of the current list.
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
            get { return "AppendPlaylistFromMatchSettings"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.AppendPlaylistFromMatchSettings"/> class for the given filename.
        /// </summary>
        /// <param name="filename">The filename of the matchsettings to append the tracks of at then end of the current list.</param>
        public AppendPlaylistFromMatchSettings(string filename)
            : base(filename)
        { }
    }
}