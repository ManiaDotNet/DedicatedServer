using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a callback for the ManiaPlanet.BillUpdated method.
    /// </summary>
    public sealed class ManiaPlanetBillUpdated : XmlRpcMethodCall<XmlRpcI4, int, XmlRpcI4, int, XmlRpcString, string, XmlRpcI4, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the Id of the bill.
        /// </summary>
        public int BillId
        {
            get { return param1.Value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ManiaPlanet.BillUpdated"; }
        }

        /// <summary>
        /// Gets the Id of the bill's state.
        /// </summary>
        public int State
        {
            get { return param2.Value; }
        }

        /// <summary>
        /// Gets the name of the bill's state.
        /// </summary>
        public string StateName
        {
            get { return param3.Value; }
        }

        /// <summary>
        /// Gets the Id of the transaction.
        /// </summary>
        public int TransactionId
        {
            get { return param4.Value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ManiaPlanetBillUpdated"/> class with default content (for parsing from Xml).
        /// </summary>
        public ManiaPlanetBillUpdated()
            : base(default(int), default(int), string.Empty, default(int))
        { }
    }
}