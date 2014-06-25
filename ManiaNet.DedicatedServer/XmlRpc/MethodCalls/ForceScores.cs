using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ForceScores method.
    /// </summary>
    public sealed class ForceScores : XmlRpcMethodCall<XmlRpcArray<XmlRpcStruct<ForceScoreStruct>, ForceScoreStruct>, XmlRpcStruct<ForceScoreStruct>[], XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the scores that will be forced.
        /// </summary>
        public IEnumerable<ForceScoreStruct> ForcedScores
        {
            get { return param1.Value.Select(strct => strct.Value); }
            set { param1.Value = value.Select(forceScoreStruct => new XmlRpcStruct<ForceScoreStruct>(forceScoreStruct)).ToArray(); }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ForceScores"; }
        }

        /// <summary>
        /// Gets or sets whether the scores will be updated silently or not.
        /// </summary>
        public bool Silent
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ForceScores"/> class with the given scores and whether to update them silently or not.
        /// </summary>
        /// <param name="silent">Whether the scores will be updated silently or not.</param>
        /// <param name="forcedScores">The scores that will be forced.</param>
        public ForceScores(bool silent, params ForceScoreStruct[] forcedScores)
            : base(forcedScores.Select(forceScoreStruct => new XmlRpcStruct<ForceScoreStruct>(forceScoreStruct)).ToArray(), silent)
        { }
    }
}