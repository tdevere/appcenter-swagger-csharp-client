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
    ///  Class for testing CodepushApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CodepushApiTests
    {
        private CodepushApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CodepushApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CodepushApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CodepushApi
            //Assert.IsInstanceOfType(typeof(CodepushApi), instance, "instance is a CodepushApi");
        }

        /// <summary>
        /// Test CodePushAcquisitionGetAcquisitionStatus
        /// </summary>
        [Test]
        public void CodePushAcquisitionGetAcquisitionStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CodePushAcquisitionGetAcquisitionStatus();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CodePushAcquisitionUpdateCheck
        /// </summary>
        [Test]
        public void CodePushAcquisitionUpdateCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentKey = null;
            //string appVersion = null;
            //string packageHash = null;
            //string label = null;
            //string clientUniqueId = null;
            //bool? isCompanion = null;
            //string previousLabelOrAppVersion = null;
            //string previousDeploymentKey = null;
            //var response = instance.CodePushAcquisitionUpdateCheck(deploymentKey, appVersion, packageHash, label, clientUniqueId, isCompanion, previousLabelOrAppVersion, previousDeploymentKey);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CodePushAcquisitionUpdateDeployStatus
        /// </summary>
        [Test]
        public void CodePushAcquisitionUpdateDeployStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReportStatusDeployBody body = null;
            //instance.CodePushAcquisitionUpdateDeployStatus(body);
            
        }
        /// <summary>
        /// Test CodePushAcquisitionUpdateDownloadStatus
        /// </summary>
        [Test]
        public void CodePushAcquisitionUpdateDownloadStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReportStatusDownloadBody body = null;
            //instance.CodePushAcquisitionUpdateDownloadStatus(body);
            
        }
        /// <summary>
        /// Test CodePushDeploymentMetricsGet
        /// </summary>
        [Test]
        public void CodePushDeploymentMetricsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.CodePushDeploymentMetricsGet(deploymentName, ownerName, appName);
            //Assert.IsInstanceOf<List<InlineResponse20062>> (response, "response is List<InlineResponse20062>");
        }
        /// <summary>
        /// Test CodePushDeploymentReleaseRollback
        /// </summary>
        [Test]
        public void CodePushDeploymentReleaseRollbackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //DeploymentNameRollbackReleaseBody body = null;
            //var response = instance.CodePushDeploymentReleaseRollback(deploymentName, ownerName, appName, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CodePushDeploymentReleasesCreate
        /// </summary>
        [Test]
        public void CodePushDeploymentReleasesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeploymentNameReleasesBody body = null;
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.CodePushDeploymentReleasesCreate(body, deploymentName, ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CodePushDeploymentReleasesDelete
        /// </summary>
        [Test]
        public void CodePushDeploymentReleasesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //instance.CodePushDeploymentReleasesDelete(deploymentName, ownerName, appName);
            
        }
        /// <summary>
        /// Test CodePushDeploymentReleasesGet
        /// </summary>
        [Test]
        public void CodePushDeploymentReleasesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.CodePushDeploymentReleasesGet(deploymentName, ownerName, appName);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        /// <summary>
        /// Test CodePushDeploymentUploadCreate
        /// </summary>
        [Test]
        public void CodePushDeploymentUploadCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.CodePushDeploymentUploadCreate(deploymentName, ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CodePushDeploymentsCreate
        /// </summary>
        [Test]
        public void CodePushDeploymentsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppNameDeploymentsBody body = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.CodePushDeploymentsCreate(body, ownerName, appName);
            //Assert.IsInstanceOf<AppNameDeploymentsBody> (response, "response is AppNameDeploymentsBody");
        }
        /// <summary>
        /// Test CodePushDeploymentsDelete
        /// </summary>
        [Test]
        public void CodePushDeploymentsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //Object body = null;
            //instance.CodePushDeploymentsDelete(deploymentName, ownerName, appName, body);
            
        }
        /// <summary>
        /// Test CodePushDeploymentsGet
        /// </summary>
        [Test]
        public void CodePushDeploymentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.CodePushDeploymentsGet(deploymentName, ownerName, appName);
            //Assert.IsInstanceOf<InlineResponse20063> (response, "response is InlineResponse20063");
        }
        /// <summary>
        /// Test CodePushDeploymentsList
        /// </summary>
        [Test]
        public void CodePushDeploymentsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerName = null;
            //string appName = null;
            //var response = instance.CodePushDeploymentsList(ownerName, appName);
            //Assert.IsInstanceOf<List<InlineResponse20063>> (response, "response is List<InlineResponse20063>");
        }
        /// <summary>
        /// Test CodePushDeploymentsPromote
        /// </summary>
        [Test]
        public void CodePushDeploymentsPromoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentName = null;
            //string promoteDeploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //PromoteReleasePromoteDeploymentNameBody body = null;
            //var response = instance.CodePushDeploymentsPromote(deploymentName, promoteDeploymentName, ownerName, appName, body);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test CodePushDeploymentsUpdate
        /// </summary>
        [Test]
        public void CodePushDeploymentsUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeploymentsDeploymentNameBody body = null;
            //string deploymentName = null;
            //string ownerName = null;
            //string appName = null;
            //instance.CodePushDeploymentsUpdate(body, deploymentName, ownerName, appName);
            
        }
        /// <summary>
        /// Test DeploymentReleasesUpdate
        /// </summary>
        [Test]
        public void DeploymentReleasesUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReleasesReleaseLabelBody body = null;
            //string deploymentName = null;
            //string releaseLabel = null;
            //string ownerName = null;
            //string appName = null;
            //var response = instance.DeploymentReleasesUpdate(body, deploymentName, releaseLabel, ownerName, appName);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test LegacyCodePushAcquisitionUpdateCheck
        /// </summary>
        [Test]
        public void LegacyCodePushAcquisitionUpdateCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string deploymentKey = null;
            //string appVersion = null;
            //string packageHash = null;
            //string label = null;
            //string clientUniqueId = null;
            //string isCompanion = null;
            //var response = instance.LegacyCodePushAcquisitionUpdateCheck(deploymentKey, appVersion, packageHash, label, clientUniqueId, isCompanion);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test LegacyCodePushAcquisitionUpdateDownloadStatus
        /// </summary>
        [Test]
        public void LegacyCodePushAcquisitionUpdateDownloadStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReportStatusDownloadBody body = null;
            //instance.LegacyCodePushAcquisitionUpdateDownloadStatus(body);
            
        }
        /// <summary>
        /// Test LegacyCodePushAcquisitionUpdateInstallsStatus
        /// </summary>
        [Test]
        public void LegacyCodePushAcquisitionUpdateInstallsStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReportStatusDeployBody body = null;
            //instance.LegacyCodePushAcquisitionUpdateInstallsStatus(body);
            
        }
    }

}
