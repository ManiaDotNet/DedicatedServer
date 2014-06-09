using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the TunnelSendDataToId method.
    /// </summary>
    public sealed class TunnelSendDataToId : MethodCall<XmlRpcInt, int, XmlRpcBase64, byte[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the data that will be send to the Id.
        /// </summary>
        public byte[] Data
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Id that the data will be send to.
        /// </summary>
        public int Id
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "TunnelSendDataToId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.TunnelSendDataToId"/> class with the given data for the given Id.
        /// </summary>
        /// <param name="id">The Id that the data will be send to.</param>
        /// <param name="data">The data that will be send to the Id.</param>
        public TunnelSendDataToId(int id, byte[] data)
            : base(id, data)
        { }
    }
}