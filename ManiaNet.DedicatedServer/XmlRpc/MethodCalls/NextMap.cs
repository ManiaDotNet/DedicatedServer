using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the NextMap method.
    /// </summary>
    public sealed class NextMap : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to clear scores in cup mode or not.
        /// </summary>
        public bool ClearCupScores
        {
            get { return !param1.Value; }
            set { param1.Value = !value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "NextMap"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.NextMap"/> class with an optional value for whether to clear cup scores or not.
        /// </summary>
        /// <param name="clearCupScores">Whether to clear scores in cup mode or not.</param>
        public NextMap(bool clearCupScores = true)
            : base(!clearCupScores)
        { }
    }
}