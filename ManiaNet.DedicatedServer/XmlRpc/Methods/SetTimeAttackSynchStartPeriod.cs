using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetTimeAttackSynchStartPeriod method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetTimeAttackSynchStartPeriod : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetTimeAttackSynchStartPeriod"; }
        }

        /// <summary>
        /// Gets or sets the new synch start period for timeattack mode in seconds.
        /// </summary>
        [UsedImplicitly]
        public int SynchStartPeriod
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetTimeAttackSynchStartPeriod"/> class for the given synch start period.
        /// </summary>
        /// <param name="synchStartPeriod">The new synch start period for timeattack mode in seconds.</param>
        public SetTimeAttackSynchStartPeriod(int synchStartPeriod)
            : base(synchStartPeriod)
        { }
    }
}