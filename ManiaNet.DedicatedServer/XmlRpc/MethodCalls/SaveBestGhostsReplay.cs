using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SaveBestGhostsReplay method.
    /// </summary>
    public sealed class SaveBestGhostsReplay : MethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the filename that the replay will be saved to. Empty string for automatic name.
        /// </summary>
        public string Filename
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the login of the player to save the best ghost of. Empty string for all players.
        /// </summary>
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SaveBestGhostsReplay"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SaveBestGhostReplay"/> class with the given login and filename.
        /// </summary>
        /// <param name="login">The login of the player to save the best ghost of. Empty string for all players.</param>
        /// <param name="filename">The filename that the replay will be saved to. Empty string for automatic name.</param>
        public SaveBestGhostsReplay(string login, string filename)
            : base(login, filename)
        { }
    }
}