using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CertificatesDeleteTest : BaseMockServerTest
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
                  "uploadedAt": "2024-01-15T09:30:00.000Z"
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
                  "uploadedAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Declarations.CertificatesDeleteAsync(
            new CertificatesDeleteDeclarationsRequest
            {
                System = "x",
                FieldKey = CertificatesDeleteDeclarationsRequestFieldKey.Certificate,
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
                  "uploadedAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Declarations.CertificatesDeleteAsync(
            new CertificatesDeleteDeclarationsRequest
            {
                System = "system",
                FieldKey = CertificatesDeleteDeclarationsRequestFieldKey.Certificate,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
