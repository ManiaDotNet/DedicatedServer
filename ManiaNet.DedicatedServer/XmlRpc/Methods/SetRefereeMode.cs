using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetRefereeMode method.
    /// </summary>
    public sealed class SetRefereeMode : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetRefereeMode"; }
        }

        /// <summary>
        /// Gets or sets the new referee mode. Use values from <see cref="ManiaNet.DedicatedServer.RefereeModes"/>.
        /// </summary>
        public int Mode
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetRefereeMode"/> class for the given mode.
        /// </summary>
        /// <param name="mode">The new referee mode. Use values from <see cref="ManiaNet.DedicatedServer.RefereeModes"/>.</param>
        public SetRefereeMode(int mode)
            : base(mode)
        { }
    }
}