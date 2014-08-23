using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ChatSend method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ChatSend : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the message that will be send to all clients.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Message
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ChatSend"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChatSend"/> class with the given message.
        /// </summary>
        /// <param name="message">The message that will be send to all clients.</param>
        public ChatSend([NotNull] string message)
            : base(message)
        { }
    }
}