using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetForcedClubLinks method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetForcedClubLinks : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new club link for clan 1.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ClubLink1
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the new club link for clan 2.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ClubLink2
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetForcedClubLinks"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetForcedClubLinks"/> class with the given club links.
        /// </summary>
        /// <param name="clubLink1">The new club link for clan 1.</param>
        /// <param name="clubLink2">The new club link for clan 2.</param>
        public SetForcedClubLinks([NotNull] string clubLink1, [NotNull] string clubLink2)
            : base(clubLink1, clubLink2)
        { }
    }
}