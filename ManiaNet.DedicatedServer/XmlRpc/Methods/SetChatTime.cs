using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SendChatTime method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetChatTime : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the chat time at the end of the map in milliseconds.
        /// </summary>
        [UsedImplicitly]
        public int ChatTime
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetChatTime"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetChatTime"/> class for the given chat time.
        /// </summary>
        /// <param name="chatTime">The chat time at the end of the map in milliseconds.</param>
        public SetChatTime(int chatTime)
            : base(chatTime)
        { }
    }
}