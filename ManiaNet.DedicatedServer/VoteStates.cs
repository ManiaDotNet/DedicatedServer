using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains constant values for the different vote states.
    /// </summary>
    [UsedImplicitly]
    public static class VoteStates
    {
        /// <summary>
        /// The vote new and hasn't completed yet.
        /// </summary>
        [UsedImplicitly]
        public const string NewVote = "NewVote";

        /// <summary>
        /// The vote was cancelled.
        /// </summary>
        [UsedImplicitly]
        public const string VoteCancelled = "VoteCancelled";

        /// <summary>
        /// The vote failed.
        /// </summary>
        [UsedImplicitly]
        public const string VoteFailed = "VoteFailed";

        /// <summary>
        /// The vote passed.
        /// </summary>
        [UsedImplicitly]
        public const string VotePassed = "VotePassed";
    }
}