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
    ///  Class for testing ErrorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ErrorsApiTests
    {
        private ErrorsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ErrorsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ErrorsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ErrorsApi
            //Assert.IsInstanceOfType(typeof(ErrorsApi), instance, "instance is a ErrorsApi");
        }

        /// <summary>
        /// Test ErrorsAppBuildsList
        /// </summary>
        [Test]
        public void ErrorsAppBuildsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string version = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //string errorType = null;
            //var response = instance.ErrorsAppBuildsList(version, start, ownerName, appName, end, top, errorType);
            //Assert.IsInstanceOf<InlineResponse20055> (response, "response is InlineResponse20055");
        }
        /// <summary>
        /// Test ErrorsAvailableVersions
        /// </summary>
        [Test]
        public void ErrorsAvailableVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //long? skip = null;
            //string filter = null;
            //string inlinecount = null;
            //string errorType = null;
            //var response = instance.ErrorsAvailableVersions(start, ownerName, appName, end, top, skip, filter, inlinecount, errorType);
            //Assert.IsInstanceOf<InlineResponse20054> (response, "response is InlineResponse20054");
        }
        /// <summary>
        /// Test ErrorsCountsPerDay
        /// </summary>
        [Test]
        public void ErrorsCountsPerDayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //string version = null;
            //DateTime? end = null;
            //string appBuild = null;
            //string errorType = null;
            //var response = instance.ErrorsCountsPerDay(start, ownerName, appName, version, end, appBuild, errorType);
            //Assert.IsInstanceOf<InlineResponse20050> (response, "response is InlineResponse20050");
        }
        /// <summary>
        /// Test ErrorsDeleteError
        /// </summary>
        [Test]
        public void ErrorsDeleteErrorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string errorId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsDeleteError(errorGroupId, errorId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20048> (response, "response is InlineResponse20048");
        }
        /// <summary>
        /// Test ErrorsErrorAttachmentLocation
        /// </summary>
        [Test]
        public void ErrorsErrorAttachmentLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorId = null;
            //string attachmentId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsErrorAttachmentLocation(errorId, attachmentId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20040> (response, "response is InlineResponse20040");
        }
        /// <summary>
        /// Test ErrorsErrorAttachmentText
        /// </summary>
        [Test]
        public void ErrorsErrorAttachmentTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorId = null;
            //string attachmentId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsErrorAttachmentText(errorId, attachmentId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20039> (response, "response is InlineResponse20039");
        }
        /// <summary>
        /// Test ErrorsErrorAttachments
        /// </summary>
        [Test]
        public void ErrorsErrorAttachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsErrorAttachments(errorId, ownerName, appName);
            //Assert.IsInstanceOf<List<InlineResponse20041>> (response, "response is List<InlineResponse20041>");
        }
        /// <summary>
        /// Test ErrorsErrorDownload
        /// </summary>
        [Test]
        public void ErrorsErrorDownloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string errorId = null;
            //string ownerName = null;
            //string appName = null;
            //string format = null;
            //var response = instance.ErrorsErrorDownload(errorGroupId, errorId, ownerName, appName, format);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test ErrorsErrorFreeDevicePercentages
        /// </summary>
        [Test]
        public void ErrorsErrorFreeDevicePercentagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //List<string> versions = null;
            //string appBuild = null;
            //string errorType = null;
            //var response = instance.ErrorsErrorFreeDevicePercentages(start, ownerName, appName, end, versions, appBuild, errorType);
            //Assert.IsInstanceOf<InlineResponse20044> (response, "response is InlineResponse20044");
        }
        /// <summary>
        /// Test ErrorsErrorGroupsSearch
        /// </summary>
        [Test]
        public void ErrorsErrorGroupsSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //string filter = null;
            //string q = null;
            //string order = null;
            //string sort = null;
            //long? top = null;
            //long? skip = null;
            //var response = instance.ErrorsErrorGroupsSearch(ownerName, appName, filter, q, order, sort, top, skip);
            //Assert.IsInstanceOf<InlineResponse20052> (response, "response is InlineResponse20052");
        }
        /// <summary>
        /// Test ErrorsErrorLocation
        /// </summary>
        [Test]
        public void ErrorsErrorLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string errorId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsErrorLocation(errorGroupId, errorId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20040> (response, "response is InlineResponse20040");
        }
        /// <summary>
        /// Test ErrorsErrorSearch
        /// </summary>
        [Test]
        public void ErrorsErrorSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //string filter = null;
            //string q = null;
            //string order = null;
            //string sort = null;
            //long? top = null;
            //long? skip = null;
            //var response = instance.ErrorsErrorSearch(ownerName, appName, filter, q, order, sort, top, skip);
            //Assert.IsInstanceOf<InlineResponse20042> (response, "response is InlineResponse20042");
        }
        /// <summary>
        /// Test ErrorsErrorStackTrace
        /// </summary>
        [Test]
        public void ErrorsErrorStackTraceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string errorId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsErrorStackTrace(errorGroupId, errorId, ownerName, appName);
            //Assert.IsInstanceOf<DiagnosticsStackTrace> (response, "response is DiagnosticsStackTrace");
        }
        /// <summary>
        /// Test ErrorsGetErrorDetails
        /// </summary>
        [Test]
        public void ErrorsGetErrorDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string errorId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsGetErrorDetails(errorGroupId, errorId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20047> (response, "response is InlineResponse20047");
        }
        /// <summary>
        /// Test ErrorsGetRetentionSettings
        /// </summary>
        [Test]
        public void ErrorsGetRetentionSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsGetRetentionSettings(ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20043> (response, "response is InlineResponse20043");
        }
        /// <summary>
        /// Test ErrorsGroupCountsPerDay
        /// </summary>
        [Test]
        public void ErrorsGroupCountsPerDayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //string version = null;
            //DateTime? end = null;
            //var response = instance.ErrorsGroupCountsPerDay(errorGroupId, start, ownerName, appName, version, end);
            //Assert.IsInstanceOf<InlineResponse20050> (response, "response is InlineResponse20050");
        }
        /// <summary>
        /// Test ErrorsGroupDetails
        /// </summary>
        [Test]
        public void ErrorsGroupDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsGroupDetails(errorGroupId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20051> (response, "response is InlineResponse20051");
        }
        /// <summary>
        /// Test ErrorsGroupErrorFreeDevicePercentages
        /// </summary>
        [Test]
        public void ErrorsGroupErrorFreeDevicePercentagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //var response = instance.ErrorsGroupErrorFreeDevicePercentages(errorGroupId, start, ownerName, appName, end);
            //Assert.IsInstanceOf<InlineResponse20044> (response, "response is InlineResponse20044");
        }
        /// <summary>
        /// Test ErrorsGroupErrorStackTrace
        /// </summary>
        [Test]
        public void ErrorsGroupErrorStackTraceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsGroupErrorStackTrace(errorGroupId, ownerName, appName);
            //Assert.IsInstanceOf<DiagnosticsStackTrace> (response, "response is DiagnosticsStackTrace");
        }
        /// <summary>
        /// Test ErrorsGroupList
        /// </summary>
        [Test]
        public void ErrorsGroupListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //string version = null;
            //string appBuild = null;
            //string groupState = null;
            //DateTime? end = null;
            //string orderby = null;
            //long? top = null;
            //string errorType = null;
            //var response = instance.ErrorsGroupList(start, ownerName, appName, version, appBuild, groupState, end, orderby, top, errorType);
            //Assert.IsInstanceOf<InlineResponse20053> (response, "response is InlineResponse20053");
        }
        /// <summary>
        /// Test ErrorsGroupModelCounts
        /// </summary>
        [Test]
        public void ErrorsGroupModelCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string ownerName = null;
            //string appName = null;
            //long? top = null;
            //var response = instance.ErrorsGroupModelCounts(errorGroupId, ownerName, appName, top);
            //Assert.IsInstanceOf<InlineResponse20046> (response, "response is InlineResponse20046");
        }
        /// <summary>
        /// Test ErrorsGroupOperatingSystemCounts
        /// </summary>
        [Test]
        public void ErrorsGroupOperatingSystemCountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string ownerName = null;
            //string appName = null;
            //long? top = null;
            //var response = instance.ErrorsGroupOperatingSystemCounts(errorGroupId, ownerName, appName, top);
            //Assert.IsInstanceOf<InlineResponse20045> (response, "response is InlineResponse20045");
        }
        /// <summary>
        /// Test ErrorsLatestErrorDetails
        /// </summary>
        [Test]
        public void ErrorsLatestErrorDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsLatestErrorDetails(errorGroupId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20047> (response, "response is InlineResponse20047");
        }
        /// <summary>
        /// Test ErrorsListForGroup
        /// </summary>
        [Test]
        public void ErrorsListForGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorGroupId = null;
            //DateTime? start = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? end = null;
            //long? top = null;
            //string model = null;
            //string os = null;
            //var response = instance.ErrorsListForGroup(errorGroupId, start, ownerName, appName, end, top, model, os);
            //Assert.IsInstanceOf<InlineResponse20049> (response, "response is InlineResponse20049");
        }
        /// <summary>
        /// Test ErrorsListSessionLogs
        /// </summary>
        [Test]
        public void ErrorsListSessionLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string errorId = null;
            //string ownerName = null;
            //string appName = null;
            //DateTime? date = null;
            //var response = instance.ErrorsListSessionLogs(errorId, ownerName, appName, date);
            //Assert.IsInstanceOf<InlineResponse20038> (response, "response is InlineResponse20038");
        }
        /// <summary>
        /// Test ErrorsUpdateState
        /// </summary>
        [Test]
        public void ErrorsUpdateStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ErrorGroupsErrorGroupIdBody body = null;
            //string errorGroupId = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.ErrorsUpdateState(body, errorGroupId, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20051> (response, "response is InlineResponse20051");
        }
    }

}