using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetValidationReplay method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetValidationReplay : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBase64, byte[]>
    {
        /// <summary>
        /// Gets or sets the login of the player that the validation replay will be returned of.
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
            get { return "GetValidationReplay"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetValidationReplay"/> class for the given login.
        /// </summary>
        /// <param name="login">The login of the player that the validation replay will be returned of.</param>
        public GetValidationReplay([NotNull] string login)
            : base(login)
        { }
    }
}