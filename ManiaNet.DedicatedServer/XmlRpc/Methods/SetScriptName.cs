using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetScriptName method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetScriptName : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetScriptName"; }
        }

        /// <summary>
        /// Gets or sets the name of the new script in script mode.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ScriptName
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetScriptName"/> class for the given script name.
        /// </summary>
        /// <param name="scriptName">The name of the new script in script mode.</param>
        public SetScriptName([NotNull] string scriptName)
            : base(scriptName)
        { }
    }
}