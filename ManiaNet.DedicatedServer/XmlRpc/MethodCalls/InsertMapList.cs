using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the InsertMapList method.
    /// </summary>
    public sealed class InsertMapList : MethodCall<XmlRpcArray<XmlRpcString, string>, XmlRpcString[], XmlRpcI4, int>
    {
        /// <summary>
        /// Gets or sets the filenames of the maps to insert after the current map.
        /// </summary>
        public IEnumerable<string> Filenames
        {
            get { return param1.Value.Select(xmlRpcString => xmlRpcString.Value); }
            set { param1.Value = value.Select(strng => new XmlRpcString(strng)).ToArray(); }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "InsertMapList"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.InsertMapList"/> class for the given filenames.
        /// </summary>
        /// <param name="filenames">The filenames of the maps to insert after the current map.</param>
        public InsertMapList(params string[] filenames)
            : base(filenames.Select(strng => new XmlRpcString(strng)).ToArray())
        { }
    }
}