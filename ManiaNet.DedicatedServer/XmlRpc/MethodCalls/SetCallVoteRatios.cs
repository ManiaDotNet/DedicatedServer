using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    public sealed class SetCallVoteRatios : MethodCall<XmlRpcArray<XmlRpcStruct<CallVoteRatioStruct>, CallVoteRatioStruct>, XmlRpcStruct<CallVoteRatioStruct>[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetCallVoteRatios"; }
        }

        /// <summary>
        /// Gets or sets the new ratios for the different call votes.
        /// </summary>
        public IEnumerable<CallVoteRatioStruct> Ratios
        {
            get { return param1.Value.Select(strct => strct.Value); }
            set { param1.Value = value.Select(callVoteRatio => new XmlRpcStruct<CallVoteRatioStruct>(callVoteRatio)).ToArray(); }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetCallVoteRatios"/> class with the given ratios.
        /// </summary>
        /// <param name="ratios">The new ratios for the different call votes.</param>
        public SetCallVoteRatios(params CallVoteRatioStruct[] ratios)
            : base(ratios.Select(callVoteRatio => new XmlRpcStruct<CallVoteRatioStruct>(callVoteRatio)).ToArray())
        { }
    }
}