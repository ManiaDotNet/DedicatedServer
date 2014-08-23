using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetServerName method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetServerName : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetServerName"; }
        }

        /// <summary>
        /// Gets or sets the new name of the server.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Name
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetServerName"/> class with the given server name.
        /// </summary>
        /// <param name="name">The new name of the server.</param>
        public SetServerName([NotNull] string name)
            : base(name)
        { }
    }
}