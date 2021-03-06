﻿using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetGameInfos method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetGameInfos : XmlRpcMethodCall<XmlRpcStruct<PassedInGameInfosStruct>, PassedInGameInfosStruct, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the new game infos.
        /// </summary>
        [NotNull, UsedImplicitly]
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
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetGameInfos"/> class for the given game infos.
        /// </summary>
        /// <param name="gameInfos">The new game infos.</param>
        public SetGameInfos([NotNull] PassedInGameInfosStruct gameInfos)
            : base(gameInfos)
        { }
    }
}