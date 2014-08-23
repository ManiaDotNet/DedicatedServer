using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ChatSendServerMessageToId method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ChatSendServerMessageToId : XmlRpcMethodCall<XmlRpcString, string, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id that the message will be send to.
        /// </summary>
        [UsedImplicitly]
        public int Id
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the message that will be send to the Id (without the server login as source).
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
            get { return "ChatSendServerMessageToId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChatSendServerMessageToId"/> class with the given message for the given Id.
        /// </summary>
        /// <param name="message">The message that will be send to the Id (without the serverlogin as source).</param>
        /// <param name="id">The Id that the message will be send to.</param>
        public ChatSendServerMessageToId([NotNull] string message, int id)
            : base(message, id)
        { }
    }
}