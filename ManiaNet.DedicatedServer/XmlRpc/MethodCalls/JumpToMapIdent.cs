using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the JumpToMapIdent method.
    /// </summary>
    public sealed class JumpToMapIdent : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the ident of the map that will be jumped to.
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
            get { return "JumpToMapIdent"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.JumpToMapIdent"/> class with the given ident.
        /// </summary>
        /// <param name="ident">The ident of the map that will be jumped to.</param>
        public JumpToMapIdent(string ident)
            : base(ident)
        { }
    }
}