using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetNextMapIdent method.
    /// </summary>
    public sealed class SetNextMapIdent : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new ident of the next map.
        /// </summary>
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetNextMapIdent"/> class with the given ident.
        /// </summary>
        /// <param name="ident">The new ident of the next map.</param>
        public SetNextMapIdent(string ident)
            : base(ident)
        { }
    }
}