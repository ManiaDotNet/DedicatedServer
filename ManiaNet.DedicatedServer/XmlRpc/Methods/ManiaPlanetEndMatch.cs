using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.EndMatch method.
    /// </summary>
    public sealed class ManiaPlanetEndMatch : XmlRpcMethodCall<XmlRpcArray<XmlRpcStruct<RankingStruct>, RankingStruct>, XmlRpcStruct<RankingStruct>[], XmlRpcI4, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.EndMatch"; }
        }

        /// <summary>
        /// Gets the rankings of the players.
        /// </summary>
        public IEnumerable<RankingStruct> Rankings
        {
            get { return param1.Value.Select(strct => strct.Value); }
        }

        /// <summary>
        /// Gets the Id of the team that one.
        /// </summary>
        public int WinnerTeam
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetEndMatch"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetEndMatch()
            : base(new XmlRpcStruct<RankingStruct>[0], default(int))
        { }
    }
}