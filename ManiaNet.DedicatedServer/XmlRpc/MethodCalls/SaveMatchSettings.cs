using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SaveMatchSettings method.
    /// </summary>
    public sealed class SaveMatchSettings : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filename to save the current matchsettings to.
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
            get { return "SaveMatchSettings"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SaveMatchSettings"/> class for the given filename.
        /// </summary>
        /// <param name="filename">The filename to save the current matchsettings to.</param>
        public SaveMatchSettings(string filename)
            : base(filename)
        { }
    }
}