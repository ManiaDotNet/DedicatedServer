using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.PlayerChat method.
    /// </summary>
    public sealed class ManiaPlanetPlayerChat : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the Id of the client that sent the message.
        /// </summary>
        [UsedImplicitly]
        public int ClientId
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the login of the client that sent the message.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ClientLogin
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets whether the message was a registered command.
        /// </summary>
        [UsedImplicitly]
        public bool IsRegisteredCmd
        {
            get { return param4.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.PlayerChat"; }
        }

        /// <summary>
        /// Gets the text of the message.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Text
        {
            get { return param3.Value; }
        }

        /// <summary>
        /// Creates an instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetPlayerChat"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetPlayerChat()
            : base(default(int), string.Empty, string.Empty, default(bool))
        { }
    }
}