using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetScriptName method.
    /// </summary>
    public sealed class SetScriptName : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
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
        public string ScriptName
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetScriptName"/> class for the given script name.
        /// </summary>
        /// <param name="scriptName">The name of the new script in script mode.</param>
        public SetScriptName(string scriptName)
            : base(scriptName)
        { }
    }
}