using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the AutoSaveValidationReplays method.
    /// </summary>
    [UsedImplicitly]
    public sealed class AutoSaveValidationReplays : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "AutoSaveValidationReplays"; }
        }

        /// <summary>
        /// Gets or sets whether validation replays of every time will be automatically saved or not.
        /// </summary>
        [UsedImplicitly]
        public bool Value
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.AutoSaveValidationReplays"/> class with the given value for whether to automatically save them or
        /// not.
        /// </summary>
        /// <param name="value">Whether validation replays of every time will be automatically saved or not.</param>
        public AutoSaveValidationReplays(bool value)
            : base(value)
        { }
    }
}