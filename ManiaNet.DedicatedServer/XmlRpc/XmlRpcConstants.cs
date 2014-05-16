using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc
{
    public static class XmlRpcConstants
    {
        /// <summary>
        /// &lt;methodCall&gt;&lt;methodName&gt;
        /// </summary>
        public const string MethodCallAndNameOpening = "<methodCall><methodName>";

        /// <summary>
        /// &lt;/methodName&gt;&lt;params&gt;
        /// </summary>
        public const string MethodNameClosingAndParamsOpening = "</methodName><params>";

        /// <summary>
        /// &lt;/param&gt;
        /// </summary>
        public const string ParamClosing = "</param>";

        /// <summary>
        /// &lt;param&gt;
        /// </summary>
        public const string ParamOpening = "<param>";

        /// <summary>
        /// &lt;/params&gt;&lt;/methodCall&gt;
        /// </summary>
        public const string ParamsAndMethodCallClosing = "</params></methodCall>";

        /// <summary>
        /// &lt;/string&gt;&lt;/value&gt;
        /// </summary>
        public const string StringValueClosing = "</string></value>";

        /// <summary>
        /// &lt;value&gt;&lt;string&gt;
        /// </summary>
        public const string StringValueOpening = "<value><string>";

        /// <summary>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// </summary>
        public const string XmlDeclaration = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
    }
}