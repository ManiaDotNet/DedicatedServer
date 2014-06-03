using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Types.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetScriptName method call.
    /// </summary>
    public sealed class ScriptNameStruct : StringCurrentAndNextValueStruct<ScriptNameStruct>
    {
        /// <summary>
        /// Gets the name of the script currently running.
        /// </summary>
        public override string CurrentValue
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets the name of the script running on the next map.
        /// </summary>
        public override string NextValue
        {
            get { throw new NotImplementedException(); }
        }
    }
}