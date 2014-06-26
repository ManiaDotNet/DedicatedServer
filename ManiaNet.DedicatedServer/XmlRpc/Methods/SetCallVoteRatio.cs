using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetCallVoteRatio method.
    /// </summary>
    public sealed class SetCallVoteRatio : XmlRpcMethodCall<XmlRpcDouble, double, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetCallVoteRatio"; }
        }

        /// <summary>
        /// Gets or sets the new default ratio for call votes. Has to be between 0 and 1.
        /// </summary>
        public double Ratio
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetCallVoteRatio"/> class with the given timeout.
        /// </summary>
        /// <param name="ratio">The new default ratio for call votes. Has to be between 0 and 1.</param>
        public SetCallVoteRatio(double ratio)
            : base(ratio)
        { }
    }
}