using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the Pay method.
    /// </summary>
    public sealed class Pay : XmlRpcMethodCall<XmlRpcString, string, XmlRpcInt, int, XmlRpcString, string, XmlRpcI4, int>
    {
        /// <summary>
        /// Gets or sets the label that will be send with the payment.
        /// </summary>
        public string Label
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "Pay"; }
        }

        /// <summary>
        /// Gets or sets the login that will receive the planets.
        /// </summary>
        public string Payee
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the amount of planets that the payee will receive.
        /// </summary>
        public int Planets
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.Pay"/> class with the given payment information.
        /// </summary>
        /// <param name="payee">The login that will receive the planets.</param>
        /// <param name="planets">The amount of planets the the payee will receive.</param>
        /// <param name="label">The label that will be send with the payment.</param>
        public Pay(string payee, int planets, string label)
            : base(payee, planets, label)
        { }
    }
}