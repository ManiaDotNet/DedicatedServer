using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the AreServiceAnnouncesDisabled [sic] method.
    /// </summary>
    public sealed class AreServiceAnnouncementsDisabled : MethodCall<XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "AreServiceAnnouncesDisabled"; } // [sic]
        }
    }
}