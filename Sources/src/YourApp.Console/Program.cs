using Mastercard.Developer.OAuth1Signer.Core.Utils;
using Mastercard.Developer.OAuth1Signer.RestSharp.Authenticators;
using System;
using System.Net;
using YourApp.MdesCustomerClient.Api;
using YourApp.MdesCustomerClient.Client;
using YourApp.MdesCustomerClient.Model;

namespace YourApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Workaround to "The request was aborted: Could not create SSL/TLS secure channel"
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var consumerKey = "<insert consumer key>";
            var signingKey = SecurityUtils.LoadPrivateKey("<insert PKCS#12 key file path>", "<insert key alias>", "<insert key password>"); // Pass X509KeyStoragFlags here
            var config = Configuration.Default;
            config.BasePath = "https://sandbox.api.mastercard.com/mdes/csapi/v2";
            config.ApiClient.RestClient.Authenticator = new RestSharpOAuth1Authenticator(consumerKey, signingKey, new Uri(config.BasePath));
            var searchApi = new SearchApi(config);
            var auditInfo = new AuditInfo("A1435477", "John Smith", "Any Bank", "5555551234");
            var tokenUniqueReference = "DWSPMC00000000010906a349d9ca4eb1a4d53e3c90a11d9c";
            var searchRequest = new SearchRequest(null, tokenUniqueReference, null, null, null, null, null, null, auditInfo);
            var response = searchApi.SearchPost(new SearchRequestSchema(searchRequest));
            System.Console.WriteLine(response.SearchResponse.Accounts.Account[0].Tokens.Token[0]);
            System.Console.ReadLine();
        }
    }
}
