using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the DisableServiceAnnounces [sic] method.
    /// </summary>
    public sealed class DisableServiceAnnouncements : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether joins/quits will be announced automatically.
        /// </summary>
        public bool Disable
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "DisableServiceAnnounces"; } // [sic]
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.DisableServiceAnnouncements"/> class with the given value for whether to disable them or not.
        /// </summary>
        /// <param name="disable">Whether joins/quits will be announced automatically.</param>
        public DisableServiceAnnouncements(bool disable)
            : base(disable)
        { }
    }
}