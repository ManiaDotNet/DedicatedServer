using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SaveCurrentReplay method.
    /// </summary>
    public sealed class SaveCurrentReplay : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filename to which the replay will be saved. Empty string for automatic name.
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
            get { return "SaveCurrentReplay"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SaveCurrentReplay"/> class with the given filename.
        /// </summary>
        /// <param name="filename">The filename to which the replay will be saved. Empty string for automatic name.</param>
        public SaveCurrentReplay(string filename)
            : base(filename)
        { }
    }
}