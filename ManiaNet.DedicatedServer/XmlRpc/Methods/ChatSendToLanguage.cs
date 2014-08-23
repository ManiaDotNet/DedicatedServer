using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ChatSendToLanguage method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ChatSendToLanguage
        : XmlRpcMethodCall
              <XmlRpcArray<XmlRpcStruct<LanguageMessageStruct>, LanguageMessageStruct>, XmlRpcStruct<LanguageMessageStruct>[], XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login that the message is send to. If it's null, the message is send to all clients.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets or sets the different messages that will be send to the different languages.
        /// The last message in the list is ued if there's no matching one.
        /// </summary>
        [NotNull, UsedImplicitly]
        public IEnumerable<LanguageMessageStruct> Messages
        {
            get { return param1.Value.Select(strct => strct.Value); }
            set { param1.Value = value.Select(message => new XmlRpcStruct<LanguageMessageStruct>(message)).ToArray(); }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ChatSendToLanguage"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChatSendServerMessageToLanguage"/> class with the given login and messages.
        /// <para/>
        /// The last message in the list is used if there's no matching one.
        /// </summary>
        /// <param name="login">The login that the message is send to.</param>
        /// <param name="messages">The different messages for different languages.</param>
        public ChatSendToLanguage([NotNull] string login, [NotNull] params LanguageMessageStruct[] messages)
            : base(messages.Select(message => new XmlRpcStruct<LanguageMessageStruct>(message)).ToArray(), login)
        { }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChatSendServerMessageToLanguage"/> class with the given messages.
        /// <para/>
        /// With no login specified, the message is send to every client.
        /// <para/>
        /// The last message in the list is used if there's no matching one.
        /// </summary>
        /// <param name="messages">The different messages for different languages.</param>
        public ChatSendToLanguage([NotNull] params LanguageMessageStruct[] messages)
            : base(messages.Select(message => new XmlRpcStruct<LanguageMessageStruct>(message)).ToArray(), null)
        { }

        /// <summary>
        /// Generates Xml containing the parameter data. Removes the last param element if there's no value for the login.
        /// </summary>
        /// <returns>An XElement containing the parameter data.</returns>
        protected override XElement generateCallParamsXml()
        {
            var paramsElement = base.generateCallParamsXml();

            if (string.IsNullOrWhiteSpace(Login))
                paramsElement.LastNode.Remove();

            return paramsElement;
        }
    }
}