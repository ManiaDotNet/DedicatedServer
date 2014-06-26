using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Base for calls to Get*List methods.
    /// </summary>
    /// <typeparam name="TStruct">The struct returned by the method.</typeparam>
    public abstract class GetList<TStruct> : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcInt, int, XmlRpcArray<XmlRpcStruct<TStruct>, TStruct>, XmlRpcStruct<TStruct>[]>
        where TStruct : BaseStruct, new()
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
        /// Gets or sets the starting index from which results will be returned.
        /// </summary>
        public int StartingIndex
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetList"/> class with the given limit and starting index.
        /// </summary>
        /// <param name="limit">The maximum number of results that will be returned.</param>
        /// <param name="startingIndex">The starting index from which results will be returned.</param>
        protected GetList(int limit, int startingIndex)
            : base(limit, startingIndex)
        { }
    }
}