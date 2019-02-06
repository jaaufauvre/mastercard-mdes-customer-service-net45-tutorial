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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using YourApp.MdesCustomerClient.Client;
using YourApp.MdesCustomerClient.Model;

namespace YourApp.MdesCustomerClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITokenActivateApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>TokenActivateResponseSchema</returns>
        TokenActivateResponseSchema TokenActivatePost (TokenActivateRequestSchema tokenActivateRequestSchema = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>ApiResponse of TokenActivateResponseSchema</returns>
        ApiResponse<TokenActivateResponseSchema> TokenActivatePostWithHttpInfo (TokenActivateRequestSchema tokenActivateRequestSchema = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of TokenActivateResponseSchema</returns>
        System.Threading.Tasks.Task<TokenActivateResponseSchema> TokenActivatePostAsync (TokenActivateRequestSchema tokenActivateRequestSchema = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of ApiResponse (TokenActivateResponseSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenActivateResponseSchema>> TokenActivatePostAsyncWithHttpInfo (TokenActivateRequestSchema tokenActivateRequestSchema = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokenActivateApi : ITokenActivateApi
    {
        private YourApp.MdesCustomerClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenActivateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenActivateApi(String basePath)
        {
            this.Configuration = new YourApp.MdesCustomerClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = YourApp.MdesCustomerClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenActivateApi"/> class
        /// </summary>
        /// <returns></returns>
        public TokenActivateApi()
        {
            this.Configuration = YourApp.MdesCustomerClient.Client.Configuration.Default;

            ExceptionFactory = YourApp.MdesCustomerClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenActivateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokenActivateApi(YourApp.MdesCustomerClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = YourApp.MdesCustomerClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = YourApp.MdesCustomerClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public YourApp.MdesCustomerClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public YourApp.MdesCustomerClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>TokenActivateResponseSchema</returns>
        public TokenActivateResponseSchema TokenActivatePost (TokenActivateRequestSchema tokenActivateRequestSchema = null)
        {
             ApiResponse<TokenActivateResponseSchema> localVarResponse = TokenActivatePostWithHttpInfo(tokenActivateRequestSchema);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>ApiResponse of TokenActivateResponseSchema</returns>
        public ApiResponse< TokenActivateResponseSchema > TokenActivatePostWithHttpInfo (TokenActivateRequestSchema tokenActivateRequestSchema = null)
        {

            var localVarPath = "/token/activate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tokenActivateRequestSchema != null && tokenActivateRequestSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(tokenActivateRequestSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenActivateRequestSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokenActivatePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenActivateResponseSchema>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenActivateResponseSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenActivateResponseSchema)));
        }

        /// <summary>
        ///  Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of TokenActivateResponseSchema</returns>
        public async System.Threading.Tasks.Task<TokenActivateResponseSchema> TokenActivatePostAsync (TokenActivateRequestSchema tokenActivateRequestSchema = null)
        {
             ApiResponse<TokenActivateResponseSchema> localVarResponse = await TokenActivatePostAsyncWithHttpInfo(tokenActivateRequestSchema);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Used to activate a token for a digitization that has been approved and provisioned, but requires additional cardholder authentication prior to activation. If the provisioning was not completed successfully, activation cannot be accomplished using Customer Service API. It is expected that a cardholder will complete the authentication process using an issuer&#39;s call center or using an issuer-supplied mobile application, and only then should the issuer use this API to activate the token. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenActivateRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of ApiResponse (TokenActivateResponseSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TokenActivateResponseSchema>> TokenActivatePostAsyncWithHttpInfo (TokenActivateRequestSchema tokenActivateRequestSchema = null)
        {

            var localVarPath = "/token/activate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (tokenActivateRequestSchema != null && tokenActivateRequestSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(tokenActivateRequestSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenActivateRequestSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokenActivatePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenActivateResponseSchema>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenActivateResponseSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenActivateResponseSchema)));
        }

    }
}
