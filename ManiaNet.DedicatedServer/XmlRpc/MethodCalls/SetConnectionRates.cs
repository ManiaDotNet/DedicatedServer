using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetConnectionRates method.
    /// </summary>
    public sealed class SetConnectionRates : MethodCall<XmlRpcInt, int, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new download rate in kilobits per second.
        /// </summary>
        public int DownloadRate
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetConnectionRates"; }
        }

        /// <summary>
        /// Gets or sets the new upload rate in kilobits per second.
        /// </summary>
        public int UploadRate
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetConnectionRates"/> class with the given rates in kilobits per second.
        /// </summary>
        /// <param name="downloadRate">The new download rate in kilobits per second.</param>
        /// <param name="uploadRate">The new upload rate in kilobits per second.</param>
        public SetConnectionRates(int downloadRate, int uploadRate)
            : base(downloadRate, uploadRate)
        { }
    }
}