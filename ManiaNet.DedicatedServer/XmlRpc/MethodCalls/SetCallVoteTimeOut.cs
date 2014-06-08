using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetCallVoteTimeOut method.
    /// </summary>
    public sealed class SetCallVoteTimeOut : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetCallVoteTimeOut"; }
        }

        /// <summary>
        /// Gets or sets the new default call vote timeout in seconds. 0 disables call votes.
        /// </summary>
        public int TimeOut
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetCallVoteTimeOut"/> class with the given timeout.
        /// </summary>
        /// <param name="timeOut">The new default call vote timeout in seconds. 0 disables call votes.</param>
        public SetCallVoteTimeOut(int timeOut)
            : base(timeOut)
        { }
    }
}