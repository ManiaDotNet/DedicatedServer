using ManiaNet.DedicatedServer.XmlRpc.Types;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
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

            var applicationVersionStruct = new XmlRpcStruct<ApplicationVersionStruct>();
            applicationVersionStruct.ParseXml(XDocument.Parse(xml).Root);

            Assert.AreEqual<string>("ManiaPlanet", applicationVersionStruct.Value.Name);
            Assert.AreEqual<string>("TMCanyon", applicationVersionStruct.Value.TitleId);
            Assert.AreEqual<string>("3.3.0", applicationVersionStruct.Value.Version);
            Assert.AreEqual<string>("2014-04-30_00_04", applicationVersionStruct.Value.Build);
            Assert.AreEqual<string>("2011-08-01", applicationVersionStruct.Value.ApiVersion);
        }

        [TestMethod]
        public void ReturnedGameInfosStruct()
        {
            #region XML

            string xml = @"<struct>
<member><name>GameMode</name>
<value><i4>2</i4></value></member>
<member><name>ChatTime</name>
<value><i4>10000</i4></value></member>
<member><name>NbChallenge</name>
<value><i4>15</i4></value></member>
<member><name>RoundsPointsLimit</name>
<value><i4>50</i4></value></member>
<member><name>RoundsUseNewRules</name>
<value><boolean>0</boolean></value></member>
<member><name>RoundsForcedLaps</name>
<value><i4>0</i4></value></member>
<member><name>TimeAttackLimit</name>
<value><i4>300000</i4></value></member>
<member><name>TimeAttackSynchStartPeriod</name>
<value><i4>0</i4></value></member>
<member><name>TeamPointsLimit</name>
<value><i4>5</i4></value></member>
<member><name>TeamMaxPoints</name>
<value><i4>6</i4></value></member>
<member><name>TeamUseNewRules</name>
<value><boolean>0</boolean></value></member>
<member><name>LapsNbLaps</name>
<value><i4>5</i4></value></member>
<member><name>LapsTimeLimit</name>
<value><i4>0</i4></value></member>
<member><name>FinishTimeout</name>
<value><i4>1</i4></value></member>
</struct>";

            #endregion XML

            var returnedGameInfosStruct = new XmlRpcStruct<ReturnedGameInfosStruct>();
            returnedGameInfosStruct.ParseXml(XDocument.Parse(xml).Root);
        }
    }
}