using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the Echo method.
    /// </summary>
    public sealed class Echo : MethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "Echo"; }
        }

        /// <summary>
        /// Gets or sets the first parameter. Seems to be the second parameter in the callback.
        /// </summary>
        public string ParameterOne
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the second parameter. Seems to be the first parameter in the callback.
        /// </summary>
        public string ParameterTwo
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.Echo"/> class with the given parameters.
        /// </summary>
        /// <param name="parameterOne">The first parameter. Seems to be the second parameter in the callback.</param>
        /// <param name="parameterTwo">The second parameter. Seems to be the first parameter in the callback.</param>
        public Echo(string parameterOne, string parameterTwo)
            : base(parameterOne, parameterTwo)
        { }
    }
}