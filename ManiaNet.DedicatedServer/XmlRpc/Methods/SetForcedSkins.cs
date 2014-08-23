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
    /// Represents a call to the SetForcedSkins method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetForcedSkins : XmlRpcMethodCall<XmlRpcArray<XmlRpcStruct<ForcedSkinStruct>, ForcedSkinStruct>, XmlRpcStruct<ForcedSkinStruct>[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the forced skins.
        /// </summary>
        [NotNull, UsedImplicitly]
        public IEnumerable<ForcedSkinStruct> ForcedSkins
        {
            get { return param1.Value.Select(strct => strct.Value); }
            set { param1.Value = value.Select(forcedSkinStruct => new XmlRpcStruct<ForcedSkinStruct>(forcedSkinStruct)).ToArray(); }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetForcedSkins"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetForcedSkins"/> class for the given skins.
        /// </summary>
        /// <param name="forcedSkins">The forced skins.</param>
        public SetForcedSkins([NotNull] params ForcedSkinStruct[] forcedSkins)
            : base(forcedSkins.Select(forcedSkinStruct => new XmlRpcStruct<ForcedSkinStruct>(forcedSkinStruct)).ToArray())
        { }
    }
}