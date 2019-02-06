# .NET 4.5: How to Integrate with the Mastercard MDES Customer Service?

## Table of Contents

- [Prerequisites](#prerequisites)
- [Step 1: Generate a .NET 4.5 API Client Library](#step1)
- [Step 2: Open and Build the Solution](#step2)
- [Step 3: Add a Console Project to the Solution](#step3)

## Prerequisites <a name="prerequisites"></a>

1. Read the [MDES Customer Service documentation](https://developer.mastercard.com/documentation/mdes-customer-service/2.0.4)
2. Download the [MDES Customer Service OpenAPI specification](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/mdes-customer-service-2.0.4.yaml)
3. Set up a project in the [Mastercard Developers Portal](https://developer.mastercard.com)
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

## Step 2: Open and Build the Solution <a name="step2"></a>

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

## Step 3: Add a Console Project to the Solution <a name="step3"></a>

1. Click *File > New > Project...*

![Step 3a](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/step3a.png)

2. Right-click on *References* and add the following dependencies to the *YourApp.Console* project: 
    - "YourApp.MdesCustomerClient"
    - "Mastercard.Developer.OAuth1Signer.Core.dll"
    - "Mastercard.Developer.OAuth1Signer.RestSharp.dll"
    - "RestSharp.dll"

![Step 3b](https://raw.githubusercontent.com/jaaufauvre/mastercard-mdes-customer-service-net45-tutorial/master/Resources/step3b.png)
