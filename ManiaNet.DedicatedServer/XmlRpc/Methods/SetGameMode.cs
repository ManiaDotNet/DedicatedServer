using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetGameMode method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetGameMode : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetGameMode"; }
        }

        /// <summary>
        /// Gets or sets the new game mode. Use values from <see cref="ManiaNet.DedicatedServer.GameModes"/>.
        /// </summary>
        [UsedImplicitly]
        public int Mode
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetGameMode"/> class for the given game mode.
        /// </summary>
        /// <param name="mode">The new game mode. USe values from <see cref="ManiaNet.DedicatedServer.GameModes"/>.</param>
        public SetGameMode(int mode)
            : base(mode)
        { }
    }
}