using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetTeamPointsLimit method.
    /// </summary>
    public sealed class SetTeamPointsLimit : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetTeamPointsLimit"; }
        }

        /// <summary>
        /// Gets or sets the new points limit in teams mode.
        /// </summary>
        public int PointsLimit
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetTeamPointsLimit"/> class for the given points limit.
        /// </summary>
        /// <param name="pointsLimit">The new points limit in teams mode.</param>
        public SetTeamPointsLimit(int pointsLimit)
            : base(pointsLimit)
        { }
    }
}