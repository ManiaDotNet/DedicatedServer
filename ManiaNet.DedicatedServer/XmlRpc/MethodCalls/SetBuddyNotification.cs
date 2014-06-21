using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetBuddyNotification method.
    /// </summary>
    public sealed class SetBuddyNotification : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to display buddy notifications in chat for the login.
        /// </summary>
        public bool DisplayBuddyNotifications
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the login to set it for. Empty string for global value.
        /// </summary>
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
            get { return "SetBuddyNotification"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetBuddyNotification"/> class with the given setting for the given login.
        /// </summary>
        /// <param name="displayBuddyNotifications">Whether to display buddy notifications in chat for the login.</param>
        /// <param name="login">The login to set it for. Default empty string for global value.</param>
        public SetBuddyNotification(bool displayBuddyNotifications, string login = "")
            : base(login, displayBuddyNotifications)
        { }
    }
}