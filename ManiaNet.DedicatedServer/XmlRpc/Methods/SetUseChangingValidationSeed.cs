using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetUseChangingValidationSeed method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetUseChangingValidationSeed : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetUseChangingValidationSeed"; }
        }

        /// <summary>
        /// Gets or sets whether the server should use a changing validation seed.
        /// </summary>
        [UsedImplicitly]
        public bool UseChangingValidationSeed
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetUseChangingValidationSeed"/> class with the given value for whether to use one.
        /// </summary>
        /// <param name="useChangingValidationSeed">Whether the server should use a changing validation seed.</param>
        public SetUseChangingValidationSeed(bool useChangingValidationSeed)
            : base(useChangingValidationSeed)
        { }
    }
}