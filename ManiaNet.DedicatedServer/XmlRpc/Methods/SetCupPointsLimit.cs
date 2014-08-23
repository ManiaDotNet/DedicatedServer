using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetCupPointsLimit method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetCupPointsLimit : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetCupPointsLimit"; }
        }

        /// <summary>
        /// Gets or sets the new points limit in cup mode.
        /// </summary>
        [UsedImplicitly]
        public int PointsLimit
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetCupPointsLimit"/> class for the given points limit.
        /// </summary>
        /// <param name="pointsLimit">The new points limit in cup mode.</param>
        public SetCupPointsLimit(int pointsLimit)
            : base(pointsLimit)
        { }
    }
}