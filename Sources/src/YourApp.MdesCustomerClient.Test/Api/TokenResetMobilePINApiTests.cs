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
    ///  Class for testing TokenResetMobilePINApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TokenResetMobilePINApiTests
    {
        private TokenResetMobilePINApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TokenResetMobilePINApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TokenResetMobilePINApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TokenResetMobilePINApi
            //Assert.IsInstanceOfType(typeof(TokenResetMobilePINApi), instance, "instance is a TokenResetMobilePINApi");
        }

        
        /// <summary>
        /// Test TokenResetmobilepinPost
        /// </summary>
        [Test]
        public void TokenResetmobilepinPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TokenResetMobilePinRequestSchema tokenResetMobilePinRequestSchema = null;
            //var response = instance.TokenResetmobilepinPost(tokenResetMobilePinRequestSchema);
            //Assert.IsInstanceOf<TokenResetMobilePinResponseSchema> (response, "response is TokenResetMobilePinResponseSchema");
        }
        
    }

}