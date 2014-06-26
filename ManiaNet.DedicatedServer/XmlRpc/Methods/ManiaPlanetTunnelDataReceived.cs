using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.TunnelDataReceived method.
    /// </summary>
    public sealed class ManiaPlanetTunnelDataReceived : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcString, string, XmlRpcBase64, byte[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the received data.
        /// </summary>
        public byte[] Data
        {
            get { return param3.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.TunnelDataReceived"; }
        }

        /// <summary>
        /// Gets the Id of the player that drove through the checkpoint.
        /// </summary>
        public int PlayerId
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the login of the player that drove through the checkpoint.
        /// </summary>
        public string PlayerLogin
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetTunnelDataReceived"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetTunnelDataReceived()
            : base(default(int), string.Empty, new byte[0])
        { }
    }
}