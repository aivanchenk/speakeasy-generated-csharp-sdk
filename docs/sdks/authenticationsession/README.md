# AuthenticationSession
(*AuthenticationSession*)

## Overview

### Available Operations

* [CreateSession](#createsession) - Create a new session
* [GetSession](#getsession) - Get session status
* [CancelSession](#cancelsession) - Cancel Authentication Session

## CreateSession

Use this endpoint to create a session. This must contain a JSON object (as described) with all the info needed.

### Example Usage

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

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [SessionRequestDto](../../Models/Components/SessionRequestDto.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CreateSessionResponse](../../Models/Requests/CreateSessionResponse.md)**

### Errors

| Error Type                         | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.APIException | 4XX, 5XX                           | \*/\*                              |

## GetSession

Use this endpoint to get information regarding a previously created session.

### Example Usage

```csharp
using Openapi;

var sdk = new Signicat();

var res = await sdk.AuthenticationSession.GetSessionAsync(
    id: "<id>",
    sessionNonce: "<value>"
);

// handle response
```

### Parameters

| Parameter                                   | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `Id`                                        | *string*                                    | :heavy_check_mark:                          | The session identifier.                     |
| `SessionNonce`                              | *string*                                    | :heavy_minus_sign:                          | The sessionNonce used for the embedded flow |

### Response

**[GetSessionResponse](../../Models/Requests/GetSessionResponse.md)**

### Errors

| Error Type                         | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.APIException | 4XX, 5XX                           | \*/\*                              |

## CancelSession

Cancel Authentication Session

### Example Usage

```csharp
using Openapi;

var sdk = new Signicat();

var res = await sdk.AuthenticationSession.CancelSessionAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter               | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `Id`                    | *string*                | :heavy_check_mark:      | The session identifier. |

### Response

**[CancelSessionResponse](../../Models/Requests/CancelSessionResponse.md)**

### Errors

| Error Type                         | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.APIException | 4XX, 5XX                           | \*/\*                              |