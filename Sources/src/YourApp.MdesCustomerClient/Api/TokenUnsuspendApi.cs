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
    public interface ITokenUnsuspendApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>TokenUnsuspendResponseSchema</returns>
        TokenUnsuspendResponseSchema TokenUnsuspendPost (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>ApiResponse of TokenUnsuspendResponseSchema</returns>
        ApiResponse<TokenUnsuspendResponseSchema> TokenUnsuspendPostWithHttpInfo (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of TokenUnsuspendResponseSchema</returns>
        System.Threading.Tasks.Task<TokenUnsuspendResponseSchema> TokenUnsuspendPostAsync (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </remarks>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of ApiResponse (TokenUnsuspendResponseSchema)</returns>
        System.Threading.Tasks.Task<ApiResponse<TokenUnsuspendResponseSchema>> TokenUnsuspendPostAsyncWithHttpInfo (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TokenUnsuspendApi : ITokenUnsuspendApi
    {
        private YourApp.MdesCustomerClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUnsuspendApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenUnsuspendApi(String basePath)
        {
            this.Configuration = new YourApp.MdesCustomerClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = YourApp.MdesCustomerClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUnsuspendApi"/> class
        /// </summary>
        /// <returns></returns>
        public TokenUnsuspendApi()
        {
            this.Configuration = YourApp.MdesCustomerClient.Client.Configuration.Default;

            ExceptionFactory = YourApp.MdesCustomerClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenUnsuspendApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokenUnsuspendApi(YourApp.MdesCustomerClient.Client.Configuration configuration = null)
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
        ///  Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>TokenUnsuspendResponseSchema</returns>
        public TokenUnsuspendResponseSchema TokenUnsuspendPost (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null)
        {
             ApiResponse<TokenUnsuspendResponseSchema> localVarResponse = TokenUnsuspendPostWithHttpInfo(tokenUnsuspendRequestSchema);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>ApiResponse of TokenUnsuspendResponseSchema</returns>
        public ApiResponse< TokenUnsuspendResponseSchema > TokenUnsuspendPostWithHttpInfo (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null)
        {

            var localVarPath = "/token/unsuspend";
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

            if (tokenUnsuspendRequestSchema != null && tokenUnsuspendRequestSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(tokenUnsuspendRequestSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenUnsuspendRequestSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokenUnsuspendPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenUnsuspendResponseSchema>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenUnsuspendResponseSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenUnsuspendResponseSchema)));
        }

        /// <summary>
        ///  Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of TokenUnsuspendResponseSchema</returns>
        public async System.Threading.Tasks.Task<TokenUnsuspendResponseSchema> TokenUnsuspendPostAsync (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null)
        {
             ApiResponse<TokenUnsuspendResponseSchema> localVarResponse = await TokenUnsuspendPostAsyncWithHttpInfo(tokenUnsuspendRequestSchema);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Used to unsuspend or resume a suspended token and return it to the active state where it may initiate new transactions. Tokens may be suspended by multiple parties (suspenders) concurrently. The token status is updated from ACTIVE to SUSPENDED when the first suspender triggers a suspend action. Additional suspenders can add their suspend action to the list of suspenders. Suspenders can unsuspend only their own suspend action. All suspenders need to perform an unsuspend action to move a token from SUSPENDED to ACTIVE. The token status will only change when the last suspender has unsuspended the token.  For CoF tokens, the only two supported suspenders are issuer and token requestor.  For Apple Pay tokens, there are some differences in behavior versus the general principles. An issuer may add themselves as a suspender to a token already suspended by a cardholder, as above. However, a cardholder cannot suspend a token already suspended by the issuer. As a special case for Apple Pay, an issuer may unsuspend (override) a token already suspended by a cardholder. However, a cardholder cannot unsuspend a token already suspended by the issuer. 
        /// </summary>
        /// <exception cref="YourApp.MdesCustomerClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tokenUnsuspendRequestSchema">Contains the details of the request message. (optional)</param>
        /// <returns>Task of ApiResponse (TokenUnsuspendResponseSchema)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TokenUnsuspendResponseSchema>> TokenUnsuspendPostAsyncWithHttpInfo (TokenUnsuspendRequestSchema tokenUnsuspendRequestSchema = null)
        {

            var localVarPath = "/token/unsuspend";
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

            if (tokenUnsuspendRequestSchema != null && tokenUnsuspendRequestSchema.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(tokenUnsuspendRequestSchema); // http body (model) parameter
            }
            else
            {
                localVarPostBody = tokenUnsuspendRequestSchema; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TokenUnsuspendPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TokenUnsuspendResponseSchema>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenUnsuspendResponseSchema) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenUnsuspendResponseSchema)));
        }

    }
}