using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetBuddyNotification method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetBuddyNotification : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login to set it for. Empty string for global value.
        /// </summary>
        [UsedImplicitly]
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
            get { return "GetBuddyNotification"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetBuddyNotification"/> class with the given setting for the given login.
        /// </summary>
        /// <param name="login">The login to get it for. Default empty string for global value.</param>
        public GetBuddyNotification([NotNull] string login = "")
            : base(login)
        { }
    }
}