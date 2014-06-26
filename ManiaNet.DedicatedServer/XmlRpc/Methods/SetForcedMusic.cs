using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetForcedMusic method.
    /// </summary>
    public sealed class SetForcedMusic : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetForcedMusic"; }
        }

        /// <summary>
        /// Gets or sets whether existing music on maps will be overridden or not.
        /// </summary>
        public bool Override
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the filename or url of the music file that is going to be played.
        /// </summary>
        public string Uri
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetForcedMusic"/> class for the given music and override setting.
        /// </summary>
        /// <param name="override">Whether existing music on maps will be overridden or not.</param>
        /// <param name="uri">The filename or url of the music file that is going to be played.</param>
        public SetForcedMusic(bool @override, string uri)
            : base(@override, uri)
        { }
    }
}