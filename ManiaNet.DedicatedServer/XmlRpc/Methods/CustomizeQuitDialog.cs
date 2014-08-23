using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the CustomizeQuitDialog method.
    /// </summary>
    [UsedImplicitly]
    public sealed class CustomizeQuitDialog : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the delay in milliseconds until the Quit button becomes active.
        /// </summary>
        [UsedImplicitly]
        public int Delay
        {
            get { return param4.Value; }
            set { param4.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Xml representing the displayed manialink.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string ManialinkPage
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "CustomizeQuitDialog"; }
        }

        /// <summary>
        /// Gets or sets whether the quit dialog will propose adding the server to the player's favorites or not.
        /// </summary>
        [UsedImplicitly]
        public bool ProposeAddFavorite
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets or sets a maniaplanet qjoin url that the client will be send to. Format: #qjoin=serverlogin@title
        /// </summary>
        [NotNull, UsedImplicitly]
        public string SendToServer
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.CustomizeQuitDialog"/> class with the given settings.
        /// </summary>
        /// <param name="manialinkPage">The Xml represneting the displayed manialink.</param>
        /// <param name="sendToServer">A maniaplanet qjoin url that the client will be send to. Format: #qjoin=serverlogin@title</param>
        /// <param name="proposeAddFavorite">Whether the quit dialog will propose adding the server to the player's favorites or not.</param>
        /// <param name="delay">The delay in milliseconds until the Quit button becomes available.</param>
        public CustomizeQuitDialog([NotNull] string manialinkPage, [NotNull] string sendToServer, bool proposeAddFavorite, int delay)
            : base(manialinkPage, sendToServer, proposeAddFavorite, delay)
        { }
    }
}