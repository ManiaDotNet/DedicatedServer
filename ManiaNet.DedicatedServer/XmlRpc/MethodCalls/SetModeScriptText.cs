using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetModeScriptText method.
    /// </summary>
    public sealed class SetModeScriptText : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetModeScriptText"; }
        }

        /// <summary>
        /// Gets or sets the mode script text.
        /// </summary>
        public string ModeScript
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetModeScriptText"/> class for the given mode script text.
        /// </summary>
        /// <param name="modeScript">The mode script text.</param>
        public SetModeScriptText(string modeScript)
            : base(modeScript)
        { }
    }
}