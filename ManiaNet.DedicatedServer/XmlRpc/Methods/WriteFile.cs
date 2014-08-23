using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the WriteFile method.
    /// </summary>
    [UsedImplicitly]
    public sealed class WriteFile : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBase64, byte[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the data that will be written to the file.
        /// </summary>
        [NotNull, UsedImplicitly]
        public byte[] Data
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the filepath relative to the Maps folder that the data will be written to.
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
            get { return "WriteFile"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.WriteFile"/> class with the given data for the given filepath.
        /// </summary>
        /// <param name="filepath">The data that will be written to the file.</param>
        /// <param name="data">The filepath relative to the Maps folder that the data will be written to.</param>
        public WriteFile([NotNull] string filepath, [NotNull] params byte[] data)
            : base(filepath, data)
        { }
    }
}