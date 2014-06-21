using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetCupRoundsPerMap method.
    /// </summary>
    public sealed class SetCupRoundsPerMap : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetCupRoundsPerMap"; }
        }

        /// <summary>
        /// Gets or sets the new number of rounds on a map in cup mode.
        /// </summary>
        public int Rounds
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetCupRoundsPerMap"/> class with the given number of rounds.
        /// </summary>
        /// <param name="rounds">The new number of rounds on a map in cup mode.</param>
        public SetCupRoundsPerMap(int rounds)
            : base(rounds)
        { }
    }
}