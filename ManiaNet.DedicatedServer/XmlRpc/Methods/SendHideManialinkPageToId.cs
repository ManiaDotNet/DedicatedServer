using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SendHideManialinkPageToId method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SendHideManialinkPageToId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id for which the manialink page will be hidden.
        /// </summary>
        [UsedImplicitly]
        public int Id
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SendHideManialinkPageToId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SendHideManialinkPageToId"/> class wit the given id.
        /// </summary>
        /// <param name="id">The Id for which the manialink page will be hidden.</param>
        public SendHideManialinkPageToId(int id)
            : base(id)
        { }
    }
}