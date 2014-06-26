using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetFinishTimeout method.
    /// </summary>
    public sealed class SetFinishTimeout : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetFinishTimeout"; }
        }

        /// <summary>
        /// Gets or sets the finish timeout in rounds and laps mode in milliseconds. 0 means default; 1 means adaptive to map length.
        /// </summary>
        public int Timeout
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetFinishTimeout"/> class for the given timeout.
        /// </summary>
        /// <param name="timeout">The finish timeout in rounds and laps mode in milliseconds. 0 means default; 1 means adaptive to map length.</param>
        public SetFinishTimeout(int timeout)
            : base(timeout)
        { }
    }
}