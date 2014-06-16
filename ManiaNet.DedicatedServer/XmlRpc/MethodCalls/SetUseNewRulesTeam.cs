using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetUseNewRulesTeam method.
    /// </summary>
    public sealed class SetUseNewRulesTeam : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetUseNewRulesTeam"; }
        }

        /// <summary>
        /// Gets or sets whether the new rules will be used in teams mode or not.
        /// </summary>
        public bool UseNewRules
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetUseNewRulesTeam"/> class with the given value for whether they will be used or not.
        /// </summary>
        /// <param name="useNewRules">Whether the new rules will be used in teams mode or not.</param>
        public SetUseNewRulesTeam(bool useNewRules)
            : base(useNewRules)
        { }
    }
}