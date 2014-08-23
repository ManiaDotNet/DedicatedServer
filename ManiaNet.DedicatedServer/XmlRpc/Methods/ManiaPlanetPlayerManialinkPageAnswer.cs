using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.PlayerManialinkPageAnswer method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ManiaPlanetPlayerManialinkPageAnswer
        : XmlRpcMethodCall
              <XmlRpcI4, int, XmlRpcString, string, XmlRpcString, string, XmlRpcArray<XmlRpcStruct<EntryValueStruct>, EntryValueStruct>, XmlRpcStruct<EntryValueStruct>[],
              XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the client's answer.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Answer
        {
            get { return param3.Value; }
        }

        /// <summary>
        /// Gets the Id of the client that answered the page.
        /// </summary>
        [UsedImplicitly]
        public int ClientId
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the login of the client that answered the page.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ClientLogin
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets the entries.
        /// </summary>
        [NotNull, UsedImplicitly]
        public IEnumerable<EntryValueStruct> Entries
        {
            get { return param4.Value.Select(strct => strct.Value); }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.PlayerManialinkPageAnswer"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetPlayerManialinkPageAnswer"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetPlayerManialinkPageAnswer()
            : base(default(int), string.Empty, string.Empty, new XmlRpcStruct<EntryValueStruct>[0])
        { }
    }
}