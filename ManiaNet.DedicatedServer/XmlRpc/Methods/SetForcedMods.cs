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
    /// Represents a call to the SetForcedMods method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetForcedMods
        : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcArray<XmlRpcStruct<ForcedModStruct>, ForcedModStruct>, XmlRpcStruct<ForcedModStruct>[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the forced mods.
        /// </summary>
        [NotNull, UsedImplicitly]
        public IEnumerable<ForcedModStruct> ForcedMods
        {
            get { return param2.Value.Select(strct => strct.Value); }
            set { param2.Value = value.Select(forcedModStruct => new XmlRpcStruct<ForcedModStruct>(forcedModStruct)).ToArray(); }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetForcedMods"; }
        }

        /// <summary>
        /// Gets or sets whether existing mods on maps will be overridden or not.
        /// </summary>
        [UsedImplicitly]
        public bool Override
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetForcedMods"/> class for the given forced mods and override setting.
        /// </summary>
        /// <param name="override">Whether existing mods on maps will be overridden or not.</param>
        /// <param name="forcedMods">The forced mods.</param>
        public SetForcedMods(bool @override, [NotNull] params ForcedModStruct[] forcedMods)
            : base(@override, forcedMods.Select(forcedModStruct => new XmlRpcStruct<ForcedModStruct>(forcedModStruct)).ToArray())
        { }
    }
}