using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the UnsetServerTag method.
    /// </summary>
    [UsedImplicitly]
    public sealed class UnsetServerTag : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "UnsetServerTag"; }
        }

        /// <summary>
        /// Gets or sets the name of the tag that will be removed.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Name
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.UnsetServerTag"/> for the given tag name.
        /// </summary>
        /// <param name="name">The name of the tag that will be removed.</param>
        public UnsetServerTag([NotNull] string name)
            : base(name)
        { }
    }
}