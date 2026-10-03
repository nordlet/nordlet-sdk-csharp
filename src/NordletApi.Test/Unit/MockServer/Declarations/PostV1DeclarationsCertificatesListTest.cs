using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsCertificatesListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "x",
                  "system": "system",
                  "fieldKey": "fieldKey",
                  "fileName": "fileName",
                  "format": "pem",
                  "fingerprint": "fingerprint",
                  "subject": "subject",
                  "issuer": "issuer",
                  "notBefore": "notBefore",
                  "notAfter": "notAfter",
                  "sha256": "sha256",
                  "health": "ok",
                  "daysLeft": 1000000,
                  "uploadedAt": "uploadedAt"
                },
                {
                  "id": "x",
                  "system": "system",
                  "fieldKey": "fieldKey",
                  "fileName": "fileName",
                  "format": "pem",
                  "fingerprint": "fingerprint",
                  "subject": "subject",
                  "issuer": "issuer",
                  "notBefore": "notBefore",
                  "notAfter": "notAfter",
                  "sha256": "sha256",
                  "health": "ok",
                  "daysLeft": 1000000,
                  "uploadedAt": "uploadedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/certificates/list")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Declarations.PostV1DeclarationsCertificatesListAsync(
            new PostV1DeclarationsCertificatesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "id",
                  "system": "system",
                  "fieldKey": "fieldKey",
                  "fileName": "fileName",
                  "format": "pem",
                  "fingerprint": "fingerprint",
                  "subject": "subject",
                  "issuer": "issuer",
                  "notBefore": "notBefore",
                  "notAfter": "notAfter",
                  "sha256": "sha256",
                  "health": "ok",
                  "daysLeft": 1000000,
                  "uploadedAt": "uploadedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/certificates/list")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Declarations.PostV1DeclarationsCertificatesListAsync(
            new PostV1DeclarationsCertificatesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
