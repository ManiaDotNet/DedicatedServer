using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SendOpenLinkToLogin method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SendOpenLinkToLogin : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the link that will be opened.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Link
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the type of the link. 0 for external browser, 1 for internal manialink browser.
        /// </summary>
        [UsedImplicitly]
        public int LinkType
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Login that the link will be send to.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SendOpenLinkToLogin"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SendOpenLinkToId"/> class with the given link and type for the given Id.
        /// </summary>
        /// <param name="login">The Login that the link will be send to.</param>
        /// <param name="link">The link that will be opened.</param>
        /// <param name="linkType">The type of the link. 0 for external browser, 1 for internal manialink browser.</param>
        public SendOpenLinkToLogin([NotNull] string login, [NotNull] string link, int linkType)
            : base(login, link, linkType)
        { }
    }
}