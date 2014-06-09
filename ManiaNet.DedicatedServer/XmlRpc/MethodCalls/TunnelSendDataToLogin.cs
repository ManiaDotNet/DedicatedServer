using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the TunnelSendDataToLogin method.
    /// </summary>
    public sealed class TunnelSendDataToLogin : MethodCall<XmlRpcString, string, XmlRpcBase64, byte[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the data that will be send to the Login.
        /// </summary>
        public byte[] Data
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the login that the data will be send to.
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
            get { return "TunnelSendDataToLogin"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.TunnelSendDataToLogin"/> class with the given data for the given Login.
        /// </summary>
        /// <param name="login">The login that the data will be send to.</param>
        /// <param name="data">The data that will be send to the Login.</param>
        public TunnelSendDataToLogin(string login, byte[] data)
            : base(login, data)
        { }
    }
}