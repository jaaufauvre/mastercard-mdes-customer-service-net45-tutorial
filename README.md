# .NET 4.5: How to Integrate with the Mastercard MDES Customer Service?

## Table of Contents

- [Overview](#overview)
- [Prerequisites](#prerequisites)
- [Step 1: Generate a .NET 4.5 API Client Library](#step1)
- [Step 2: Open and Build the Generated Solution](#step2)
- [Step 3: Add a Console App Project to the Solution](#step3)
- [Step 4: Extend ApiClient to Use JSON](#step4)
- [Step 5: Send Requests to the MDES Search API](#step5)

## Overview <a name="overview"></a>
Mastercard provides client libraries for integrating with its services, but the .NET packages don't support .NET Framework 4.5, whose support ended in 2016:
- The [C# OAuth1 Signer lib](https://github.com/Mastercard/oauth1-signer-csharp) supports [.NET standard](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) 1.3 (.NET Framework 4.6+)
- [Mastercard Core](https://www.nuget.org/packages/MasterCard-Core/) and [Mastercard MDES Customer Service](https://www.nuget.org/packages/MasterCard-MdesCustomerService/) SDKs support .NET Framework 4.6.1+

This tutorial explains how to consume the Mastercard MDES Customer Service from a .NET 4.5 app by generating an API client library with OpenAPI generator and signing HTTP requests using a [.NET 4.5 version of the OAuth1 Signer lib](https://github.com/jaaufauvre/oauth1-signer-csharp-net45).

## Prerequisites <a name="prerequisites"></a>

1. Read the [MDES Customer Service documentation](https://developer.mastercard.com/documentation/mdes-customer-service/2.0.4)
2. Download the [MDES Customer Service OpenAPI specification](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/mdes-customer-service-2.0.4.yaml)
3. Set up a project in the [Mastercard Developers Portal](https://developer.mastercard.com), add the MDES Customer Service API to it:

![Project](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/prerequisites-project-setup.png)

4. Checkout and build the [.NET 4.5 version of the OAuth1 Signer library](https://github.com/jaaufauvre/oauth1-signer-csharp-net45)

## Step 1: Generate a .NET 4.5 API Client Library <a name="step1"></a>

A .NET 4.5 client library for MDES Customer Service can be generated using the following command:

```shell
java -jar openapi-generator-cli.jar generate -i mdes-customer-service-2.0.4.yaml -g csharp -c config.json -o mdes-customer-service-net45-tutorial
```
config.json:
```json
{ 
    "targetFramework": "v4.5",
    "packageName": "YourApp.MdesCustomerClient" 
}
```

See also: [OpenAPI Generator (executable)](https://mvnrepository.com/artifact/org.openapitools/openapi-generator-cli)

## Step 2: Open and Build the Generated Solution <a name="step2"></a>

1. Navigate to the *mdes-customer-service-net45-tutorial/src* folder
2. Fix the project files (.csproj) by deleting `Condition="Exists('..\..\packages')"` in `HintPath` elements, example:
```xml
<Reference Include="RestSharp">
    <HintPath>..\..\packages\RestSharp.105.1.0\lib\net45\RestSharp.dll</HintPath>
</Reference>
```
3. Open *YourApp.MdesCustomerClient.sln*
4. Click *Build > Rebuild Solution*

![Step 2](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/step2.png)

## Step 3: Add a Console App Project to the Solution <a name="step3"></a>

1. Click *File > New > Project...*
2. Choose *Console App (.NET Framework)* and configure the project the following way:

![Step 3a](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/step3a.png)

3. Right-click on *References* and add the following dependencies to the `YourApp.Console` project: 
    - `YourApp.MdesCustomerClient`
    - `Mastercard.Developer.OAuth1Signer.Core.dll` ([.NET 4.5 version](https://github.com/jaaufauvre/oauth1-signer-csharp-net45))
    - `Mastercard.Developer.OAuth1Signer.RestSharp.dll` ([.NET 4.5 version](https://github.com/jaaufauvre/oauth1-signer-csharp-net45))
    - `RestSharp.dll`

![Step 3b](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/step3b.png)

## Step 4: Extend `ApiClient` to Use JSON <a name="step4"></a>

By default, the MDES Customer Service is accepting and returning XML payloads when our generated code expects JSON to be used.

To indicate the service we speak JSON, create a new class in the `YourApp.MdesCustomerClient` project defining the partial method `InterceptRequest` the following way:

```csharp
using RestSharp;

namespace YourApp.MdesCustomerClient.Client
{
    /// <summary>
    /// Extends the generated ApiClient class.
    /// </summary>
    public partial class ApiClient
    {
        /// <summary>
        /// Adds "Format=JSON" to the RestSharp request so that the service accepts and returns JSON instead of XML.
        /// </summary>
        partial void InterceptRequest(IRestRequest request) => request.AddQueryParameter("Format", "JSON");
    }
}
```

![Step 4](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/step4.png)

## Step 5: Send Requests to the [MDES Search API](https://developer.mastercard.com/documentation/mdes-customer-service/2.0.4#search) <a name="step5"></a>

1. Update *[Program.cs](https://github.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/blob/master/Sources/src/YourApp.Console/Program.cs)* with the following code:

```csharp
class Program
{
    static void Main(string[] args)
    {
        // The request was aborted: Could not create SSL/TLS secure channel
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
```

2. Use your own `consumerKey`, `pkcs12KeyFilePath`, `signingKeyAlias`, `signingKeyAlias` and `keyStorageFlags`. 
3. Click *Debug*
4. You should get a result similar to this one:

![Step 5](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/step5.png)
