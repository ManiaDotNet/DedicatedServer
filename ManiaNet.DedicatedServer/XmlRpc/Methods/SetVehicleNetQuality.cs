using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetVehicleNetQuality method.
    /// </summary>
    public sealed class SetVehicleNetQuality : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetVehicleNetQuality"; }
        }

        /// <summary>
        /// Gets or sets the new vehicle quality. Use values from <see cref="ManiaNet.DedicatedServer.VehicleNetQualities"/>.
        /// </summary>
        public int Quality
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetVehicleNetQuality"/> class with the given quality value.
        /// </summary>
        /// <param name="quality">The new vehicle quality. Use values from <see cref="ManiaNet.DedicatedServer.VehicleNetQualities"/>.</param>
        public SetVehicleNetQuality(int quality)
            : base(quality)
        { }
    }
}