using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetValidationReplay method.
    /// </summary>
    public sealed class GetValidationReplay : MethodCall<XmlRpcString, string, XmlRpcBase64, byte[]>
    {
        /// <summary>
        /// Gets or sets the login of the player that the validation replay will be returned of.
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
            get { return "GetValidationReplay"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.GetValidationReplay"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the player that the validation replay will be returned of.</param>
        public GetValidationReplay(string login)
            : base(login)
        { }
    }
}