using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SaveBlackList method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SaveBlackList : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filepath to save the blacklist to.
        /// </summary>
        [NotNull, UsedImplicitly]
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SaveBlackList"/> class for the given filepath.
        /// </summary>
        /// <param name="filepath">The filepath to save the blacklist to.</param>
        public SaveBlackList([NotNull] string filepath)
            : base(filepath)
        { }
    }
}