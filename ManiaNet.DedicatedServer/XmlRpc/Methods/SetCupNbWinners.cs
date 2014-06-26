using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetCupNbWinners method.
    /// </summary>
    public sealed class SetCupNbWinners : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetCupNbWinners"; }
        }

        /// <summary>
        /// Gets or sets the new number of players that have to finish the map before the round is considered over.
        /// </summary>
        public int Winners
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetCupNbWinners"/> class with the given number of winners.
        /// </summary>
        /// <param name="winners">The new number of players that have to finish the map before the round is considered over.</param>
        public SetCupNbWinners(int winners)
            : base(winners)
        { }
    }
}