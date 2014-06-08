using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetGuestList method.
    /// </summary>
    public sealed class GetGuestList : MethodCall<XmlRpcInt, int, XmlRpcInt, int, XmlRpcArray<XmlRpcStruct<GuestListInfoStruct>, GuestListInfoStruct>, XmlRpcStruct<GuestListInfoStruct>[]>
    {
        /// <summary>
        /// Gets or sets the maximum number of results that will be returned.
        /// </summary>
        public int Limit
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetGuestList"; }
        }

        /// <summary>
        /// Gets or sets the starting index from which results will be returned.
        /// </summary>
        public int StartingIndex
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.GetGuestList"/> class with the given limit and starting index.
        /// </summary>
        /// <param name="limit">The maximum number of results that will be returned.</param>
        /// <param name="startingIndex">The starting index from which results will be returned.</param>
        public GetGuestList(int limit, int startingIndex)
            : base(limit, startingIndex)
        { }
    }
}