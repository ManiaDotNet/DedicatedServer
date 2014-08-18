using ManiaNet.DedicatedServer.XmlRpc.Structs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.Tests.XmlRpc
{
    [TestClass]
    public class Structs
    {
        [TestMethod]
        public void AreRoundTripSave()
        {
            global::XmlRpc.Testing.Structs.AreRoundTripSave((success, type, reason) => Assert.IsTrue(success, string.Format("{0} {1}", type, reason)),
                typeof(ApplicationVersionStruct).Assembly);
        }
    }
}