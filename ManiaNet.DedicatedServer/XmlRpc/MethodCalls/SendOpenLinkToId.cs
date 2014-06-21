using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SendOpenLinkToId method.
    /// </summary>
    public sealed class SendOpenLinkToId : MethodCall<XmlRpcInt, int, XmlRpcString, string, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id that the link will be send to.
        /// </summary>
        public int Id
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the link that will be opened.
        /// </summary>
        public string Link
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the type of the link. 0 for external browser, 1 for internal manialink browser.
        /// </summary>
        public int LinkType
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SendOpenLinkToId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SendOpenLinkToId"/> class with the given link and type for the given Id.
        /// </summary>
        /// <param name="id">The Id that the link will be send to.</param>
        /// <param name="link">The link that will be opened.</param>
        /// <param name="linkType">The type of the link. 0 for external browser, 1 for internal manialink browser.</param>
        public SendOpenLinkToId(int id, string link, int linkType)
            : base(id, link, linkType)
        { }
    }
}