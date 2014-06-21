using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetNbLaps method.
    /// </summary>
    public sealed class SetNbLaps : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new number of laps in laps mode. 0 means the number set by the map is used.
        /// </summary>
        public int Laps
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetNbLaps"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetNbLaps"/> class for the given number of laps.
        /// </summary>
        /// <param name="laps">The new number of laps in laps mode. 0 means the number set by the map is used.</param>
        public SetNbLaps(int laps)
            : base(laps)
        { }
    }
}