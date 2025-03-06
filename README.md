# Openapi

Developer-friendly & type-safe Csharp SDK specifically catered to leverage *Openapi* API.

<div align="left">
    <a href="https://www.speakeasy.com/?utm_source=openapi&utm_campaign=csharp"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


<br /><br />
> [!IMPORTANT]
> This SDK is not yet ready for production use. To complete setup please follow the steps outlined in your [workspace](https://app.speakeasy.com/org/signicat/sdks). Delete this section before > publishing to a package manager.

<!-- Start Summary [summary] -->
## Summary

Signicat Authentication REST API: Signicat's Authentication REST API allows you to interact with the Signicat [eID Hub](https://developer.signicat.com/docs/eid-hub/). Our digital solutions enable identity verification and authentication through a wide selection of electronic [ID methods](https://developer.signicat.com/identity-methods/). 
 The Authentication REST API is a REST API with all request and response bodies formatted in JSON. 
 # Authorisation
 For more information on how to access the Authentication REST API, see the [Accessing Signicat API products](https://developer.signicat.com/docs/accessing-api-products.html) guide in our developer documentation.
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [Openapi](#openapi)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
* [Development](#development)
  * [Maturity](#maturity)
  * [Contributions](#contributions)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/Openapi/Openapi.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Openapi;
using Openapi.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new Signicat();

SessionRequestDto req = new SessionRequestDto() {
    PrefilledInput = new PrefilledInput() {
        Nin = "07128312345",
        Mobile = "+4799716935",
        Email = "bruce@wayneenterprice.com",
        UserName = "brucewayne",
        DateOfBirth = System.DateTime.Parse("1973-12-07"),
        DeviceId = "136OP-A1",
        FirstName = "Bruce",
        LastName = "Wayne",
        BankAccountNumber = "0071234567",
        Organisation = "Signicat",
    },
    AdditionalParameters = new Dictionary<string, string>() {
        { "sbid_flow", "QR" },
        { "sbid_end_user_ip", "127.0.0.1" },
    },
    CallbackUrls = new CallbackUrls() {
        Success = "https://example.com/success",
        Abort = "https://example.com/abort",
        Error = "https://example.com/error",
    },
    EncryptionPublicKey = new EncryptionKey() {
        Kty = Kty.Rsa,
        Use = Use.Enc,
        Kid = "encryption-key-04ceb013816d6244aca3310fa69b0bcf",
        Alg = Alg.RsaOaep,
        E = "AQAB",
        N = "zN4Vqjwfs8uSqlOyjJLxw89BzkOW_blablabla-kv7wEllGQYysBSoj2ULs9qqQd",
        Crv = "P-256",
        X = "O_rs_R-2hZmBYaUzMlvBCwRosV8mDGzKv-kVSG9PgVY",
        Y = "1Xw6_lF0VCHQjbIBtunedGA3UnldovAiCC97_9LkM0w",
        D = null,
    },
    RequestedLoa = RequestedLoa.Low,
    Tags = new List<string>() {
        "tag1",
        "tag2",
    },
    ReturnUrl = "https://example.com/auth_callback",
    EmbeddedParentDomains = new List<string>() {
        "signicat.com",
        "example.com",
    },
    AllowedProviders = new List<string>() {
        "nbid",
        "sbid",
        "idin",
        "digid",
        "eherkenning",
        "spid",
    },
    Language = "en",
    Flow = SessionRequestDtoFlow.Redirect,
    ThemeId = "agkaa12",
    RequestedAttributes = new List<string>() {
        "firstName",
        "lastName",
        "email",
        "dateOfBirth",
        "phoneNumber",
        "address",
        "gender",
    },
    ExternalReference = "my-reference-12345",
    UsageReference = "my-usage-reference-12345",
    SessionLifetime = 600,
    RequestDomain = "myapp.app.signicat.com",
};

var res = await sdk.AuthenticationSession.CreateSessionAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AuthenticationSession](docs/sdks/authenticationsession/README.md)

* [CreateSession](docs/sdks/authenticationsession/README.md#createsession) - Create a new session
* [GetSession](docs/sdks/authenticationsession/README.md#getsession) - Get session status
* [CancelSession](docs/sdks/authenticationsession/README.md#cancelsession) - Cancel Authentication Session


</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `Openapi.Models.Errors.APIException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `Request`     | *HttpRequestMessage*  | The HTTP request      |
| `Response`    | *HttpResponseMessage* | The HTTP response     |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `CreateSessionAsync` method throws the following exceptions:

| Error Type                         | Status Code | Content Type |
| ---------------------------------- | ----------- | ------------ |
| Openapi.Models.Errors.APIException | 4XX, 5XX    | \*/\*        |

### Example

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Errors;
using System;
using System.Collections.Generic;

var sdk = new Signicat();

try
{
    SessionRequestDto req = new SessionRequestDto() {
        PrefilledInput = new PrefilledInput() {
            Nin = "07128312345",
            Mobile = "+4799716935",
            Email = "bruce@wayneenterprice.com",
            UserName = "brucewayne",
            DateOfBirth = System.DateTime.Parse("1973-12-07"),
            DeviceId = "136OP-A1",
            FirstName = "Bruce",
            LastName = "Wayne",
            BankAccountNumber = "0071234567",
            Organisation = "Signicat",
        },
        AdditionalParameters = new Dictionary<string, string>() {
            { "sbid_flow", "QR" },
            { "sbid_end_user_ip", "127.0.0.1" },
        },
        CallbackUrls = new CallbackUrls() {
            Success = "https://example.com/success",
            Abort = "https://example.com/abort",
            Error = "https://example.com/error",
        },
        EncryptionPublicKey = new EncryptionKey() {
            Kty = Kty.Rsa,
            Use = Use.Enc,
            Kid = "encryption-key-04ceb013816d6244aca3310fa69b0bcf",
            Alg = Alg.RsaOaep,
            E = "AQAB",
            N = "zN4Vqjwfs8uSqlOyjJLxw89BzkOW_blablabla-kv7wEllGQYysBSoj2ULs9qqQd",
            Crv = "P-256",
            X = "O_rs_R-2hZmBYaUzMlvBCwRosV8mDGzKv-kVSG9PgVY",
            Y = "1Xw6_lF0VCHQjbIBtunedGA3UnldovAiCC97_9LkM0w",
            D = null,
        },
        RequestedLoa = RequestedLoa.Low,
        Tags = new List<string>() {
            "tag1",
            "tag2",
        },
        ReturnUrl = "https://example.com/auth_callback",
        EmbeddedParentDomains = new List<string>() {
            "signicat.com",
            "example.com",
        },
        AllowedProviders = new List<string>() {
            "nbid",
            "sbid",
            "idin",
            "digid",
            "eherkenning",
            "spid",
        },
        Language = "en",
        Flow = SessionRequestDtoFlow.Redirect,
        ThemeId = "agkaa12",
        RequestedAttributes = new List<string>() {
            "firstName",
            "lastName",
            "email",
            "dateOfBirth",
            "phoneNumber",
            "address",
            "gender",
        },
        ExternalReference = "my-reference-12345",
        UsageReference = "my-usage-reference-12345",
        SessionLifetime = 600,
        RequestDomain = "myapp.app.signicat.com",
    };

    var res = await sdk.AuthenticationSession.CreateSessionAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is Openapi.Models.Errors.APIException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Openapi;
using Openapi.Models.Components;
using System;
using System.Collections.Generic;

var sdk = new Signicat(serverUrl: "https://api.signicat.com/auth/rest");

SessionRequestDto req = new SessionRequestDto() {
    PrefilledInput = new PrefilledInput() {
        Nin = "07128312345",
        Mobile = "+4799716935",
        Email = "bruce@wayneenterprice.com",
        UserName = "brucewayne",
        DateOfBirth = System.DateTime.Parse("1973-12-07"),
        DeviceId = "136OP-A1",
        FirstName = "Bruce",
        LastName = "Wayne",
        BankAccountNumber = "0071234567",
        Organisation = "Signicat",
    },
    AdditionalParameters = new Dictionary<string, string>() {
        { "sbid_flow", "QR" },
        { "sbid_end_user_ip", "127.0.0.1" },
    },
    CallbackUrls = new CallbackUrls() {
        Success = "https://example.com/success",
        Abort = "https://example.com/abort",
        Error = "https://example.com/error",
    },
    EncryptionPublicKey = new EncryptionKey() {
        Kty = Kty.Rsa,
        Use = Use.Enc,
        Kid = "encryption-key-04ceb013816d6244aca3310fa69b0bcf",
        Alg = Alg.RsaOaep,
        E = "AQAB",
        N = "zN4Vqjwfs8uSqlOyjJLxw89BzkOW_blablabla-kv7wEllGQYysBSoj2ULs9qqQd",
        Crv = "P-256",
        X = "O_rs_R-2hZmBYaUzMlvBCwRosV8mDGzKv-kVSG9PgVY",
        Y = "1Xw6_lF0VCHQjbIBtunedGA3UnldovAiCC97_9LkM0w",
        D = null,
    },
    RequestedLoa = RequestedLoa.Low,
    Tags = new List<string>() {
        "tag1",
        "tag2",
    },
    ReturnUrl = "https://example.com/auth_callback",
    EmbeddedParentDomains = new List<string>() {
        "signicat.com",
        "example.com",
    },
    AllowedProviders = new List<string>() {
        "nbid",
        "sbid",
        "idin",
        "digid",
        "eherkenning",
        "spid",
    },
    Language = "en",
    Flow = SessionRequestDtoFlow.Redirect,
    ThemeId = "agkaa12",
    RequestedAttributes = new List<string>() {
        "firstName",
        "lastName",
        "email",
        "dateOfBirth",
        "phoneNumber",
        "address",
        "gender",
    },
    ExternalReference = "my-reference-12345",
    UsageReference = "my-usage-reference-12345",
    SessionLifetime = 600,
    RequestDomain = "myapp.app.signicat.com",
};

var res = await sdk.AuthenticationSession.CreateSessionAsync(req);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically. Any manual changes added to internal files will be overwritten on the next generation. 
We look forward to hearing your feedback. Feel free to open a PR or an issue with a proof of concept and we'll do our best to include it in a future release. 

### SDK Created by [Speakeasy](https://www.speakeasy.com/?utm_source=openapi&utm_campaign=csharp)
