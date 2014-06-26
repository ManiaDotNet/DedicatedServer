using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a class to the ChatSendToLogin method.
    /// </summary>
    public sealed class ChatSendToLogin : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login that the message will be send to.
        /// </summary>
        public string Login
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the message that will be send to the login.
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
            get { return "ChatSendToLogin"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChatSendToLogin"/> class with the given message for the given login.
        /// </summary>
        /// <param name="message">The message that will be send to the login.</param>
        /// <param name="login">The login that the message will be send to. Can be a list of comma separated logins.</param>
        public ChatSendToLogin(string message, string login)
            : base(message, login)
        { }
    }
}