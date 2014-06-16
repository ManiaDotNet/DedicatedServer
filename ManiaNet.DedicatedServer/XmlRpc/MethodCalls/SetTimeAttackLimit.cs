using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetTimeAttackLimit method.
    /// </summary>
    public sealed class SetTimeAttackLimit : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetTimeAttackLimit"; }
        }

        /// <summary>
        /// Gets or sets the new timelimit for timeattack mode in seconds.
        /// </summary>
        public int Timelimit
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetTimeAttackLimit"/> class for the given timelimit.
        /// </summary>
        /// <param name="timelimit">The new timelimit for timeattack mode in seconds.</param>
        public SetTimeAttackLimit(int timelimit)
            : base(timelimit)
        { }
    }
}