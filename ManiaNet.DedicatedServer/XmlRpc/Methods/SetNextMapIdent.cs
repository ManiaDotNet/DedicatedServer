using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetNextMapIdent method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetNextMapIdent : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new ident of the next map.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Ident
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetNextMapIdent"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetNextMapIdent"/> class with the given ident.
        /// </summary>
        /// <param name="ident">The new ident of the next map.</param>
        public SetNextMapIdent([NotNull] string ident)
            : base(ident)
        { }
    }
}