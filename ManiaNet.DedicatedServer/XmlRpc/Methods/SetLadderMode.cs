using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetLadderMode method.
    /// </summary>
    public sealed class SetLadderMode : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetLadderMode"; }
        }

        /// <summary>
        /// Gets or sets the new mode. Use values from <see cref="ManiaNet.DedicatedServer.LadderModes"/>.
        /// </summary>
        public int Mode
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetLadderMode"/> class with the given mode.
        /// </summary>
        /// <param name="mode">The new mode. Use values from <see cref="ManiaNet.DedicatedServer.LadderModes"/>.</param>
        public SetLadderMode(int mode)
            : base(mode)
        { }
    }
}