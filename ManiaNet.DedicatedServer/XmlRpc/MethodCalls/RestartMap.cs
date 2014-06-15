using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the RestartMap method.
    /// </summary>
    public sealed class RestartMap : MethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to clear the scores in cup mode or not.
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
            get { return "RestartMap"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.RestartMap"/> class with an optional value to clear cup scores.
        /// </summary>
        /// <param name="clearCupScores">Whether to clear the scores in cup mode or not.</param>
        public RestartMap(bool clearCupScores = true)
            : base(!clearCupScores)
        { }
    }
}