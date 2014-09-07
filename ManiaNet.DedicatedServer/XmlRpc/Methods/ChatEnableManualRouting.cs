using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ChatEnableManualRooting method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ChatEnableManualRouting : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether Server messages will be automatically forwarded.
        /// </summary>
        [UsedImplicitly]
        public bool AutomaticallyForwardServerMessages
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ChatEnableManualRouting"; }
        }

        /// <summary>
        /// Gets or sets whether Player chat will be manually routed.
        /// </summary>
        [UsedImplicitly]
        public bool RoutChatManually
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChatEnableManualRouting"/> class with the given options.
        /// </summary>
        /// <param name="routChatManually">Whether Player chat will be manually routed.</param>
        /// <param name="automaticallyForwardServerMessages">Whether Server messages will be automatically forwarded.</param>
        public ChatEnableManualRouting(bool routChatManually, bool automaticallyForwardServerMessages)
            : base(routChatManually, automaticallyForwardServerMessages)
        { }
    }
}