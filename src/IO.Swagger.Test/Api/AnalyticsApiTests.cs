/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AnalyticsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AnalyticsApiTests
    {
        private AnalyticsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AnalyticsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalyticsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AnalyticsApi
            //Assert.IsInstanceOfType(typeof(AnalyticsApi), instance, "instance is a AnalyticsApi");
        }

        /// <summary>
        /// Test AnalyticsAudienceNameExists
        /// </summary>
        [Test]
        public void AnalyticsAudienceNameExistsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string audienceName = null;
            //string ownerName = null;
            //string appName = null;
            //instance.AnalyticsAudienceNameExists(audienceName, ownerName, appName);
            
        }
        /// <summary>
        /// Test AnalyticsCrashCounts
        /// </summary>
        [Test]
        public void AnalyticsCrashCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsCrashCounts(start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<InlineResponse20095> (response, "response is InlineResponse20095");
        }
        /// <summary>
        /// Test AnalyticsCrashFreeDevicePercentages
        /// </summary>
        [Test]
        public void AnalyticsCrashFreeDevicePercentagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string version = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //var response = instance.AnalyticsCrashFreeDevicePercentages(start, version, ownerName, appName, end);
            //Assert.IsInstanceOf<InlineResponse20091> (response, "response is InlineResponse20091");
        }
        /// <summary>
        /// Test AnalyticsCrashGroupCounts
        /// </summary>
        [Test]
        public void AnalyticsCrashGroupCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crashGroupId = null;
            //string version = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //var response = instance.AnalyticsCrashGroupCounts(crashGroupId, version, start, ownerName, appName, end);
            //Assert.IsInstanceOf<InlineResponse20095> (response, "response is InlineResponse20095");
        }
        /// <summary>
        /// Test AnalyticsCrashGroupModelCounts
        /// </summary>
        [Test]
        public void AnalyticsCrashGroupModelCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crashGroupId = null;
            //string version = null;
            //string ownerName = null;
            //string appName = null;
            //long? top = null;
            //var response = instance.AnalyticsCrashGroupModelCounts(crashGroupId, version, ownerName, appName, top);
            //Assert.IsInstanceOf<InlineResponse20094> (response, "response is InlineResponse20094");
        }
        /// <summary>
        /// Test AnalyticsCrashGroupOperatingSystemCounts
        /// </summary>
        [Test]
        public void AnalyticsCrashGroupOperatingSystemCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crashGroupId = null;
            //string version = null;
            //string ownerName = null;
            //string appName = null;
            //long? top = null;
            //var response = instance.AnalyticsCrashGroupOperatingSystemCounts(crashGroupId, version, ownerName, appName, top);
            //Assert.IsInstanceOf<InlineResponse20093> (response, "response is InlineResponse20093");
        }
        /// <summary>
        /// Test AnalyticsCrashGroupTotals
        /// </summary>
        [Test]
        public void AnalyticsCrashGroupTotalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crashGroupId = null;
            //string version = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsCrashGroupTotals(crashGroupId, version, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20092> (response, "response is InlineResponse20092");
        }
        /// <summary>
        /// Test AnalyticsCrashGroupsTotals
        /// </summary>
        [Test]
        public void AnalyticsCrashGroupsTotalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AnalyticsCrashGroupsBody body = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsCrashGroupsTotals(body, ownerName, appName);
            //Assert.IsInstanceOf<List<InlineResponse20096>> (response, "response is List<InlineResponse20096>");
        }
        /// <summary>
        /// Test AnalyticsCreateOrUpdateAudience
        /// </summary>
        [Test]
        public void AnalyticsCreateOrUpdateAudienceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AudiencesAudienceNameBody body = null;
            //string audienceName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsCreateOrUpdateAudience(body, audienceName, ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsDeleteAudience
        /// </summary>
        [Test]
        public void AnalyticsDeleteAudienceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string audienceName = null;
            //string ownerName = null;
            //string appName = null;
            //instance.AnalyticsDeleteAudience(audienceName, ownerName, appName);
            
        }
        /// <summary>
        /// Test AnalyticsDeviceCounts
        /// </summary>
        [Test]
        public void AnalyticsDeviceCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //string appBuild = null;
            //var response = instance.AnalyticsDeviceCounts(start, ownerName, appName, end, versions, appBuild);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsDistributionReleaseCounts
        /// </summary>
        [Test]
        public void AnalyticsDistributionReleaseCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DistributionReleaseCountsBody body = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsDistributionReleaseCounts(body, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20090> (response, "response is InlineResponse20090");
        }
        /// <summary>
        /// Test AnalyticsEventCount
        /// </summary>
        [Test]
        public void AnalyticsEventCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsEventCount(eventName, start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<InlineResponse20086> (response, "response is InlineResponse20086");
        }
        /// <summary>
        /// Test AnalyticsEventDeviceCount
        /// </summary>
        [Test]
        public void AnalyticsEventDeviceCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsEventDeviceCount(eventName, start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<InlineResponse20087> (response, "response is InlineResponse20087");
        }
        /// <summary>
        /// Test AnalyticsEventPerDeviceCount
        /// </summary>
        [Test]
        public void AnalyticsEventPerDeviceCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsEventPerDeviceCount(eventName, start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<InlineResponse20089> (response, "response is InlineResponse20089");
        }
        /// <summary>
        /// Test AnalyticsEventPerSessionCount
        /// </summary>
        [Test]
        public void AnalyticsEventPerSessionCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsEventPerSessionCount(eventName, start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<InlineResponse20088> (response, "response is InlineResponse20088");
        }
        /// <summary>
        /// Test AnalyticsEventProperties
        /// </summary>
        [Test]
        public void AnalyticsEventPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsEventProperties(eventName, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20085> (response, "response is InlineResponse20085");
        }
        /// <summary>
        /// Test AnalyticsEventPropertyCounts
        /// </summary>
        [Test]
        public void AnalyticsEventPropertyCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //string eventPropertyName = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //long? top = null;
            //var response = instance.AnalyticsEventPropertyCounts(eventName, eventPropertyName, start, ownerName, appName, end, versions, top);
            //Assert.IsInstanceOf<InlineResponse20084> (response, "response is InlineResponse20084");
        }
        /// <summary>
        /// Test AnalyticsEvents
        /// </summary>
        [Test]
        public void AnalyticsEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //List<string> eventName = null;
            //long? top = null;
            //long? skip = null;
            //string inlinecount = null;
            //string orderby = null;
            //var response = instance.AnalyticsEvents(start, ownerName, appName, end, versions, eventName, top, skip, inlinecount, orderby);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsEventsDelete
        /// </summary>
        [Test]
        public void AnalyticsEventsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //string ownerName = null;
            //string appName = null;
            //instance.AnalyticsEventsDelete(eventName, ownerName, appName);
            
        }
        /// <summary>
        /// Test AnalyticsEventsDeleteLogs
        /// </summary>
        [Test]
        public void AnalyticsEventsDeleteLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventName = null;
            //string ownerName = null;
            //string appName = null;
            //instance.AnalyticsEventsDeleteLogs(eventName, ownerName, appName);
            
        }
        /// <summary>
        /// Test AnalyticsGenericLogFlow
        /// </summary>
        [Test]
        public void AnalyticsGenericLogFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //DateTime? start = null;
            //var response = instance.AnalyticsGenericLogFlow(ownerName, appName, start);
            //Assert.IsInstanceOf<InlineResponse20083> (response, "response is InlineResponse20083");
        }
        /// <summary>
        /// Test AnalyticsGetAudience
        /// </summary>
        [Test]
        public void AnalyticsGetAudienceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string audienceName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsGetAudience(audienceName, ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsLanguageCounts
        /// </summary>
        [Test]
        public void AnalyticsLanguageCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsLanguageCounts(start, ownerName, appName, end, top, versions);
            //Assert.IsInstanceOf<InlineResponse20082> (response, "response is InlineResponse20082");
        }
        /// <summary>
        /// Test AnalyticsListAudiences
        /// </summary>
        [Test]
        public void AnalyticsListAudiencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //bool? includeDisabled = null;
            //var response = instance.AnalyticsListAudiences(ownerName, appName, includeDisabled);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsListCustomProperties
        /// </summary>
        [Test]
        public void AnalyticsListCustomPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsListCustomProperties(ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsListDeviceProperties
        /// </summary>
        [Test]
        public void AnalyticsListDevicePropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsListDeviceProperties(ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsListDevicePropertyValues
        /// </summary>
        [Test]
        public void AnalyticsListDevicePropertyValuesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string propertyName = null;
            //string ownerName = null;
            //string appName = null;
            //string contains = null;
            //var response = instance.AnalyticsListDevicePropertyValues(propertyName, ownerName, appName, contains);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsLogFlow
        /// </summary>
        [Test]
        public void AnalyticsLogFlowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //DateTime? start = null;
            //var response = instance.AnalyticsLogFlow(ownerName, appName, start);
            //Assert.IsInstanceOf<InlineResponse20081> (response, "response is InlineResponse20081");
        }
        /// <summary>
        /// Test AnalyticsModelCounts
        /// </summary>
        [Test]
        public void AnalyticsModelCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsModelCounts(start, ownerName, appName, end, top, versions);
            //Assert.IsInstanceOf<InlineResponse20080> (response, "response is InlineResponse20080");
        }
        /// <summary>
        /// Test AnalyticsOperatingSystemCounts
        /// </summary>
        [Test]
        public void AnalyticsOperatingSystemCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsOperatingSystemCounts(start, ownerName, appName, end, top, versions);
            //Assert.IsInstanceOf<InlineResponse20079> (response, "response is InlineResponse20079");
        }
        /// <summary>
        /// Test AnalyticsPerDeviceCounts
        /// </summary>
        [Test]
        public void AnalyticsPerDeviceCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsPerDeviceCounts(start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<InlineResponse20076> (response, "response is InlineResponse20076");
        }
        /// <summary>
        /// Test AnalyticsPlaceCounts
        /// </summary>
        [Test]
        public void AnalyticsPlaceCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsPlaceCounts(start, ownerName, appName, end, top, versions);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsSessionCounts
        /// </summary>
        [Test]
        public void AnalyticsSessionCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsSessionCounts(start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<List<InlineResponse20078>> (response, "response is List<InlineResponse20078>");
        }
        /// <summary>
        /// Test AnalyticsSessionDurationsDistribution
        /// </summary>
        [Test]
        public void AnalyticsSessionDurationsDistributionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsSessionDurationsDistribution(start, ownerName, appName, end, versions);
            //Assert.IsInstanceOf<InlineResponse20077> (response, "response is InlineResponse20077");
        }
        /// <summary>
        /// Test AnalyticsTestAudience
        /// </summary>
        [Test]
        public void AnalyticsTestAudienceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DefinitionTestBody body = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AnalyticsTestAudience(body, ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AnalyticsVersions
        /// </summary>
        [Test]
        public void AnalyticsVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //List<string> versions = null;
            //var response = instance.AnalyticsVersions(start, ownerName, appName, end, top, versions);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test AppBlockLogs
        /// </summary>
        [Test]
        public void AppBlockLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //var response = instance.AppBlockLogs(ownerName, appName);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test CrashesListSessionLogs
        /// </summary>
        [Test]
        public void CrashesListSessionLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string crashId = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? date = null;
            //var response = instance.CrashesListSessionLogs(crashId, ownerName, appName, date);
            //Assert.IsInstanceOf<InlineResponse20065> (response, "response is InlineResponse20065");
        }
        /// <summary>
        /// Test DevicesBlockLogs
        /// </summary>
        [Test]
        public void DevicesBlockLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string installId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.DevicesBlockLogs(installId, ownerName, appName);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
    }

}
