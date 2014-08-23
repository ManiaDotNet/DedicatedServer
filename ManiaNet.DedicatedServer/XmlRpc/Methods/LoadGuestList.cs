using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the LoadGuestList method.
    /// </summary>
    [UsedImplicitly]
    public sealed class LoadGuestList : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filepath to load the Guestlist from.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Filepath
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "LoadGuestList"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.LoadGuestList"/> class for the given filepath.
        /// </summary>
        /// <param name="filepath">The filepath to load the Guestlist from.</param>
        public LoadGuestList([NotNull] string filepath)
            : base(filepath)
        { }
    }
}