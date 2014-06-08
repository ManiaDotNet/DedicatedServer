using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the Ban method.
    /// </summary>
    public sealed class Ban : MethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of the player that will be kicked.
        /// </summary>
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the ban message. May be null.
        /// </summary>
        public string Message
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "Ban"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.Ban"/> class with the given login and optional message.
        /// </summary>
        /// <param name="login">The login that will be kicked.</param>
        /// <param name="message">The optional ban message.</param>
        public Ban(string login, string message = null)
            : base(login, message)
        { }

        /// <summary>
        /// Generates Xml containing the parameter data. Removes the last param element if there's no value for the message.
        /// </summary>
        /// <returns>An XElement containing the parameter data.</returns>
        protected override XElement generateParamsXml()
        {
            XElement paramsElement = base.generateParamsXml();

            if (string.IsNullOrWhiteSpace(Message))
                paramsElement.LastNode.Remove();

            return paramsElement;
        }
    }
}