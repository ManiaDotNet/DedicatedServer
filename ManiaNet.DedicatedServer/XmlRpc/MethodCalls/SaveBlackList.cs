using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SaveBlackList method.
    /// </summary>
    public sealed class SaveBlackList : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filepath to save the blacklist to.
        /// </summary>
        public string Filepath
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SaveBlackList"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SaveBlackList"/> class for the given filepath.
        /// </summary>
        /// <param name="filepath">The filepath to save the blacklist to.</param>
        public SaveBlackList(string filepath)
            : base(filepath)
        { }
    }
}