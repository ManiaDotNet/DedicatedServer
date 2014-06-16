using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the ChooseNextMapList method.
    /// </summary>
    public sealed class ChooseNextMapList : MethodCall<XmlRpcArray<XmlRpcString, string>, XmlRpcString[], XmlRpcI4, int>
    {
        /// <summary>
        /// Gets or sets the filenames of the maps that are supposed to be played next.
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
            get { return "ChooseNextMapList"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.ChooseNextMapList"/> class for the given filenames.
        /// </summary>
        /// <param name="filenames">The filenames of the maps that are supposed to be played next.</param>
        public ChooseNextMapList(params string[] filenames)
            : base(filenames.Select(strng => new XmlRpcString(strng)).ToArray())
        { }
    }
}