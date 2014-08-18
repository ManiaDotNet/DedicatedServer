using ManiaNet.DedicatedServer.XmlRpc.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.Tests.XmlRpc
{
    [TestClass]
    public class MethodCalls
    {
        [TestMethod]
        public void AreRoundTripSave()
        {
            global::XmlRpc.Testing.MethodCalls.AreRoundTripSave((success, type, reason) => Assert.IsTrue(success, string.Format("{0} {1}", type, reason)), typeof(AddGuest).Assembly);
        }
    }
}