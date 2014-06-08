using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the AddGuestId method.
    /// </summary>
    public sealed class AddGuestId : MethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id that will be added to the guestlist.
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
            get { return "AddGuestId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.AddGuestId"/> class for the given Id.
        /// </summary>
        /// <param name="id">The Id that will be added to the guestlist.</param>
        public AddGuestId(int id)
            : base(id)
        { }
    }
}