using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsCertificatesDeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "system": "x",
              "fieldKey": "certificate"
            }
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
                    .WithPath("/v1/declarations/certificates/delete")
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

        var response = await Client.Declarations.PostV1DeclarationsCertificatesDeleteAsync(
            new PostV1DeclarationsCertificatesDeleteRequest
            {
                System = "x",
                FieldKey = PostV1DeclarationsCertificatesDeleteRequestFieldKey.Certificate,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "system": "system",
              "fieldKey": "certificate"
            }
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
                    .WithPath("/v1/declarations/certificates/delete")
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

        var response = await Client.Declarations.PostV1DeclarationsCertificatesDeleteAsync(
            new PostV1DeclarationsCertificatesDeleteRequest
            {
                System = "system",
                FieldKey = PostV1DeclarationsCertificatesDeleteRequestFieldKey.Certificate,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
