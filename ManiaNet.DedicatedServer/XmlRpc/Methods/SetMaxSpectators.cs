using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetMaxSpectators method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetMaxSpectators : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetMaxSpectators"; }
        }

        /// <summary>
        /// Gets or sets the new maximum number of spectators.
        /// </summary>
        [UsedImplicitly]
        public int Spectators
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetMaxSpectators"/> class with the given number of spectators.
        /// </summary>
        /// <param name="spectators">The new maximum number of spectators.</param>
        public SetMaxSpectators(int spectators)
            : base(spectators)
        { }
    }
}