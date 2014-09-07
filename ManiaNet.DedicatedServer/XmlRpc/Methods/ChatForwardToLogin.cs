using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ChatForwardToLogin method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ChatForwardToLogin : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ChatForwardToLogin"; }
        }

        /// <summary>
        /// Gets or sets the recipient Login of the forwarded message.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string RecipientLogin
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets or sets the sender Login of the forwarded message.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string SenderLogin
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Text of the forwarded message.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Text
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChatForwardToLogin"/> class with the giving Message information.
        /// </summary>
        /// <param name="text">The Text of the forwarded message.</param>
        /// <param name="senderLogin">The sender Login of the forwarded message.</param>
        /// <param name="recipientLogin">The recipient Login of the forwarded message.</param>
        public ChatForwardToLogin([NotNull] string text, [NotNull] string senderLogin, [NotNull] string recipientLogin)
            : base(text, senderLogin, recipientLogin)
        { }
    }
}