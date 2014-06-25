using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the JumpToMapIndex method.
    /// </summary>
    public sealed class JumpToMapIndex : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the index of the map that will be jumped to.
        /// </summary>
        public int Index
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "JumpToMapIndex"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.JumpToMapIndex"/> class with the given index.
        /// </summary>
        /// <param name="index">The index of the map that will be jumped to.</param>
        public JumpToMapIndex(int index)
            : base(index)
        { }
    }
}