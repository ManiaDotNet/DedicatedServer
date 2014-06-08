using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the AddGuest method.
    /// </summary>
    public sealed class AddGuest : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login that will be added to the guestlist.
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
            get { return "AddGuest"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.AddGuest"/> class for the given login.
        /// </summary>
        /// <param name="login">The login that will be added to the guestlist.</param>
        public AddGuest(string login)
            : base(login)
        { }
    }
}