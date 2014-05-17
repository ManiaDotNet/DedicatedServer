using ManiaNet.DedicatedServer.XmlRpc.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ManiaNet.Tests.DedicatedServer.XmlRpc.Types
{
    [TestClass]
    public class StructTests
    {
        [TestMethod]
        public void ApplicationVersion()
        {
            #region XML

            string xml = @"<struct>
<member><name>Name</name>
<value><string>ManiaPlanet</string></value></member>
<member><name>TitleId</name>
<value>TMCanyon</value></member>
<member><name>Version</name>
<value><string>3.3.0</string></value></member>
<member><name>Build</name>
<value><string>2014-04-30_00_04</string></value></member>
<member><name>ApiVersion</name>
<value><string>2011-08-01</string></value></member>
</struct>";

            #endregion XML

            var applicationVersionStruct = new XmlRpcStruct<ManiaNet.DedicatedServer.XmlRpc.Types.Structs.XmlRpcApplicationVersionStruct>();
            applicationVersionStruct.ParseXml(XDocument.Parse(xml).Root);

            Assert.AreEqual<string>("ManiaPlanet", applicationVersionStruct.Value.Name.Value);
            Assert.AreEqual<string>("TMCanyon", applicationVersionStruct.Value.TitleId.Value);
            Assert.AreEqual<string>("3.3.0", applicationVersionStruct.Value.Version.Value);
            Assert.AreEqual<string>("2014-04-30_00_04", applicationVersionStruct.Value.Build.Value);
            Assert.AreEqual<string>("2011-08-01", applicationVersionStruct.Value.ApiVersion.Value);
        }
    }
}