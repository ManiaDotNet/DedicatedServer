using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetServerTag method.
    /// </summary>
    public sealed class SetServerTag : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetServerTag"; }
        }

        /// <summary>
        /// Gets or sets the name of the new tag.
        /// </summary>
        public string Name
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the value associated with the new tag.
        /// </summary>
        public string Value
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetServerTag"/> class with the given value for the given name of the tag.
        /// </summary>
        /// <param name="name">The name of the new tag.</param>
        /// <param name="value">The value associated with the new tag.</param>
        public SetServerTag(string name, string value)
            : base(name, value)
        { }
    }
}