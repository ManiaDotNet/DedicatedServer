using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetUseNewRulesRound method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetUseNewRulesRound : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetUseNewRulesRound"; }
        }

        /// <summary>
        /// Gets or sets whether the new rules will be used in rounds mode or not.
        /// </summary>
        [UsedImplicitly]
        public bool UseNewRules
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetUseNewRulesRound"/> class with the given value for whether they will be used or not.
        /// </summary>
        /// <param name="useNewRules">Whether the new rules will be used in rounds mode or not.</param>
        public SetUseNewRulesRound(bool useNewRules)
            : base(useNewRules)
        { }
    }
}