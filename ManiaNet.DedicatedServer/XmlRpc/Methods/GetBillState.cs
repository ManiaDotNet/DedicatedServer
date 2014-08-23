using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetBillState method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetBillState : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcStruct<BillStateStruct>, BillStateStruct>
    {
        /// <summary>
        /// Gets or sets the Id of the bill that the state will be returned of.
        /// </summary>
        [UsedImplicitly]
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
            get { return "GetBillState"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetBillState"/> class for the given bill Id.
        /// </summary>
        /// <param name="id">The Id of the bill that the state will be returned of.</param>
        public GetBillState(int id)
            : base(id)
        { }
    }
}