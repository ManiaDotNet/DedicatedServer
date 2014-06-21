using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the ChatSendServerMessage method.
    /// </summary>
    public sealed class ChatSendServerMessage : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the message that will be send to all clients (without the server login as source).
        /// </summary>
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
            get { return "ChatSendServerMessage"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.ChatSendServerMessage"/> class with the given message.
        /// </summary>
        /// <param name="message">The message that will be send to all clients (without the server login as source).</param>
        public ChatSendServerMessage(string message)
            : base(message)
        { }
    }
}