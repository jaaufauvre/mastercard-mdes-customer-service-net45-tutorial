# .NET 4.5: How to Integrates with the Mastercard MDES Customer Service?

## Table of Contents

- [Prerequisites](#prerequisites)
- [Step 1: Generate a .NET 4.5 API Client Library](#step1)
- [Step 2: Open and Build the Solution](#step2)

  
## Prerequisites <a name="prerequisites"></a>

1. Read the [MDES Customer Service documentation](https://developer.mastercard.com/documentation/mdes-customer-service/2.0.4)
2. Download the [MDES Customer Service OpenAPI specification](https://raw.githubusercontent.com/jaaufauvre/oauth1-signer-csharp-net45/master/Resources/mdes-customer-service-2.0.4.yaml)
3. Set up a project in the [Mastercard Developers Portal](https://developer.mastercard.com)
4. Checkout and build the [.NET 4.5 version of the OAuth1 Signer library](https://github.com/jaaufauvre/oauth1-signer-csharp-net45)

## Step 1: Generate a .NET 4.5 API Client Library <a name="step1"></a>

A .NET 4.5 client library for MDES Customer Service can be generated using the following command:

```shell
java -jar openapi-generator-cli.jar generate -i mdes-customer-service-2.0.4.yaml -g csharp -c config.json -o mdes-customer-service-net45-tutorial
```
config.json:
```json
{ "targetFramework": "v4.5" }
```

## Step 2: Open and Build the Solution <a name="step2"></a>

1. Navigate to the *mdes-customer-service-net45-tutorial* folder
2. Open *Org.OpenAPITools.sln*
3. Click *Build > Rebuild Solution*

![alt text](https://raw.githubusercontent.com/jaaufauvre/oauth1-signer-csharp-net45/master/Resources/step2.png)