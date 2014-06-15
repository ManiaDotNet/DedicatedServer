using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetGameInfos method.
    /// </summary>
    public sealed class SetGameInfos : MethodCall<XmlRpcStruct<PassedInGameInfosStruct>, PassedInGameInfosStruct, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new game infos.
        /// </summary>
        public PassedInGameInfosStruct GameInfos
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetGameInfos"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetGameInfos"/> class for the given game infos.
        /// </summary>
        /// <param name="gameInfos">The new game infos.</param>
        public SetGameInfos(PassedInGameInfosStruct gameInfos)
            : base(gameInfos)
        { }
    }
}