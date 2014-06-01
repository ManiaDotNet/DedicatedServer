using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetCallVoteTimeOut method call.
    /// </summary>
    public sealed class CallVoteTimeOutStruct : I4CurrentAndNextValueStruct<CallVoteTimeOutStruct>
    {
        /// <summary>
        /// Gets the current call-vote timeout in milliseconds.
        /// </summary>
        public override int CurrentValue
        {
            get { return currentValue.Value; }
        }

        /// <summary>
        /// Gets the next call-vote timeout in milliseconds.
        /// </summary>
        public override int NextValue
        {
            get { return nextValue.Value; }
        }
    }
}