using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetNextMapIndex method.
    /// </summary>
    public sealed class SetNextMapIndex : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new index of the next map.
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
            get { return "SetNextMapIndex"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetNextMapIndex"/> class with the given index.
        /// </summary>
        /// <param name="index">The new index of the next map.</param>
        public SetNextMapIndex(int index)
            : base(index)
        { }
    }
}