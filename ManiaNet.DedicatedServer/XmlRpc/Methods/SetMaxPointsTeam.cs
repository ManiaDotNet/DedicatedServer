using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetMaxPointsTeam method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetMaxPointsTeam : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetMaxPointsTeam"; }
        }

        /// <summary>
        /// Gets or sets the new maximum amount of points a team can get per round in teams mode.
        /// </summary>
        [UsedImplicitly]
        public int Points
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetMaxPointsTeam"/> class with the given number of points.
        /// </summary>
        /// <param name="pointsLimit">The new maximum amount of points a team can get per round in teams mode.</param>
        public SetMaxPointsTeam(int pointsLimit)
            : base(pointsLimit)
        { }
    }
}