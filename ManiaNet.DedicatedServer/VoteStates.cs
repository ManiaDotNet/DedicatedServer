using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different vote states.
    /// </summary>
    public static class VoteStates
    {
        public const string NewVote = "NewVote";
        public const string VoteCancelled = "VoteCancelled";
        public const string VoteFailed = "VoteFailed";
        public const string VotePassed = "VotePassed";
    }
}