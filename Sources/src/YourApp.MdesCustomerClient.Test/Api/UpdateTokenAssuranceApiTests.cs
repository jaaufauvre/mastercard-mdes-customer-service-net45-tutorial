/* 
 * MDES Customer Service
 *
 * This API provides our Issuer partners with resources to help resolve consumer queries about payment accounts enabled through our digitization platform.
 *
 * OpenAPI spec version: 2.0.4
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using YourApp.MdesCustomerClient.Client;
using YourApp.MdesCustomerClient.Api;
using YourApp.MdesCustomerClient.Model;

namespace YourApp.MdesCustomerClient.Test
{
    /// <summary>
    ///  Class for testing UpdateTokenAssuranceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UpdateTokenAssuranceApiTests
    {
        private UpdateTokenAssuranceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UpdateTokenAssuranceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UpdateTokenAssuranceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UpdateTokenAssuranceApi
            //Assert.IsInstanceOfType(typeof(UpdateTokenAssuranceApi), instance, "instance is a UpdateTokenAssuranceApi");
        }

        
        /// <summary>
        /// Test UpdatetokenassurancePost
        /// </summary>
        [Test]
        public void UpdatetokenassurancePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateTokenAssuranceRequestSchema updateTokenAssuranceRequestSchema = null;
            //var response = instance.UpdatetokenassurancePost(updateTokenAssuranceRequestSchema);
            //Assert.IsInstanceOf<UpdateTokenAssuranceResponseSchema> (response, "response is UpdateTokenAssuranceResponseSchema");
        }
        
    }

}
