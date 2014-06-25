using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetRoundCustomPoints method.
    /// </summary>
    public sealed class SetRoundCustomPoints : XmlRpcMethodCall<XmlRpcArray<XmlRpcInt, int>, XmlRpcInt[], XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetRoundCustomPoints"; }
        }

        /// <summary>
        /// Gets or sets the points for the players. Order corresponds to the players from first to last.
        /// </summary>
        public IEnumerable<int> Points
        {
            get { return param1.Value.Select(xmlRpcInt => xmlRpcInt.Value); }
            set { param1.Value = value.Select(@int => new XmlRpcInt(@int)).ToArray(); }
        }

        /// <summary>
        /// Gets or sets whether the constraint checking on the points will be relaxed or not.
        /// </summary>
        public bool RelaxConstraintChecks
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetRoundCustomPoints"/> class with the given points.
        /// </summary>
        /// <param name="points">The points for the players. Order corresponds to the players from first to last.</param>
        /// <param name="relaxConstraintChecks">Whether the constraint checking on the points will be relaxed or not.</param>
        public SetRoundCustomPoints(IEnumerable<int> points, bool relaxConstraintChecks = false)
            : base(points.Select(@int => new XmlRpcInt(@int)).ToArray(), relaxConstraintChecks)
        { }
    }
}