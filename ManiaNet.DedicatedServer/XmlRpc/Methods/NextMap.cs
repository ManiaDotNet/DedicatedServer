using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the NextMap method.
    /// </summary>
    [UsedImplicitly]
    public sealed class NextMap : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to clear scores in cup mode or not.
        /// </summary>
        [UsedImplicitly]
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.NextMap"/> class with an optional value for whether to clear cup scores or not.
        /// </summary>
        /// <param name="clearCupScores">Whether to clear scores in cup mode or not.</param>
        public NextMap(bool clearCupScores = true)
            : base(!clearCupScores)
        { }
    }
}