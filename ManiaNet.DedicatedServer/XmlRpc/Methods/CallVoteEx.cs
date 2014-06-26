using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the CallVoteEx method.
    /// </summary>
    public sealed class CallVoteEx : XmlRpcMethodCall<XmlRpcString, string, XmlRpcDouble, double, XmlRpcInt, int, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the command to be executed when the call vote is successful.
        /// <para/>
        /// Has to correspond to an Xml Rpc method call.
        /// </summary>
        public string Command
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "CallVoteEx"; }
        }

        /// <summary>
        /// Gets or sets the required vote ratio between 0 and 1 for the vote to be successful.
        /// </summary>
        public double Ratio
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the timeout the call vote in seconds. -1 and 0 mean the default value, 1 means indefinite.
        /// </summary>
        public int TimeOut
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets or sets who will be allowed to vote on the call vote. 0 means only active players, 1 means only players, 2 means everyone (including spectators).
        /// </summary>
        public int Voters
        {
            get { return param4.Value; }
            set { param4.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.CallVote"/> class with the given settings for the call vote.
        /// </summary>
        /// <param name="command">The method to be executed when the call vote is successful. Has to correspond to an Xml Rpc method call.</param>
        /// <param name="ratio">The required vote ratio between 0 and 1 for the vote to be successful.</param>
        /// <param name="timeOut">Timeout for the call vote in seconds. -1 and 0 mean the default value, 1 means indefinite.</param>
        /// <param name="voters">Who will be allowed to vote on the call vote. 0 means only active players, 1 means only players, 2 means everyone (including spectators).</param>
        public CallVoteEx(string command, double ratio, int timeOut, int voters)
            : base(command, ratio, timeOut, voters)
        { }
    }
}