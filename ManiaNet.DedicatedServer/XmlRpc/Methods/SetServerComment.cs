using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetServerComment method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetServerComment : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new comment of the server.
        /// </summary>
        [UsedImplicitly]
        public string Comment
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetServerComment"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetServerComment"/> class with the given server comment.
        /// </summary>
        /// <param name="comment">The new comment of the server.</param>
        public SetServerComment([NotNull] string comment)
            : base(comment)
        { }
    }
}