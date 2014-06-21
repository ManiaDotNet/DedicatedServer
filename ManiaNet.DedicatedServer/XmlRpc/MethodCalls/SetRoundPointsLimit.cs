using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetRoundPointsLimit method.
    /// </summary>
    public sealed class SetRoundPointsLimit : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetRoundPointsLimit"; }
        }

        /// <summary>
        /// Gets or sets the new points limit in rounds mode.
        /// </summary>
        public int PointsLimit
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetRoundPointsLimit"/> class for the given points limit.
        /// </summary>
        /// <param name="pointsLimit">The new points limit in rounds mode.</param>
        public SetRoundPointsLimit(int pointsLimit)
            : base(pointsLimit)
        { }
    }
}