using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    /// <summary>
    /// Contains values for the possible Api versions.
    /// </summary>
    [UsedImplicitly]
    public static class ApiVersions
    {
        /// <summary>
        /// Api Identifier for the API Version from 2011-08-01.
        /// </summary>
        [UsedImplicitly]
        public const string Api201108 = "2011-08-01";

        /// <summary>
        /// API Identifier for the API Version from 2011-10-06.
        /// </summary>
        [UsedImplicitly]
        public const string Api201110 = "2011-10-06";

        /// <summary>
        /// API Identifier for the API Version from 2012-06-19.
        /// </summary>
        [UsedImplicitly]
        public const string Api2012 = "2012-06-19";

        /// <summary>
        /// API Identifier for the API Version from 2013-04-16.
        /// </summary>
        [UsedImplicitly]
        public const string Api2013 = "2013-04-16";
    }
}