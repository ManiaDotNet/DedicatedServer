using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetHideServer method.
    /// </summary>
    public sealed class SetHideServer : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetHideServer"; }
        }

        /// <summary>
        /// Gets or sets the new visability mode. Use values from <see cref="ManiaNet.DedicatedServer.VisibilityModes"/>.
        /// </summary>
        public int Visability
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetHideServer"/> class with the given visibility mode.
        /// </summary>
        /// <param name="visability">The new visibility mode. Use values from <see cref="ManiaNet.DedicatedServer.VisibilityModes"/>.</param>
        public SetHideServer(int visability)
            : base(visability)
        { }
    }
}