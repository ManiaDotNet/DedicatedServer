using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the AddMapList method.
    /// </summary>
    [UsedImplicitly]
    public sealed class AddMapList : XmlRpcMethodCall<XmlRpcArray<XmlRpcString, string>, XmlRpcString[], XmlRpcI4, int>
    {
        /// <summary>
        /// Gets or sets the filenames of the maps to add.
        /// </summary>
        [NotNull, UsedImplicitly]
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
            get { return "AddMapList"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.AddMapList"/> class for the given filenames.
        /// </summary>
        /// <param name="filenames">The filenames of the maps to add.</param>
        public AddMapList([NotNull] params string[] filenames)
            : base(filenames.Select(strng => new XmlRpcString(strng)).ToArray())
        { }
    }
}