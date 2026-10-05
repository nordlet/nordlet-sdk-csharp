using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SubmissionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "obligation": "lt-isaf",
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "obligation": "obligation",
              "periodYear": 1000000,
              "periodMonth": 1000000,
              "variant": "variant",
              "status": "generated",
              "fileName": "fileName",
              "fileId": "x",
              "externalRef": "externalRef",
              "message": "message",
              "ruleKey": "ruleKey",
              "period": "period",
              "documentKey": "documentKey",
              "amendment": 1000000,
              "origin": "origin",
              "transportSystem": "transportSystem",
              "environment": "test",
              "submittedAt": "2024-01-15T09:30:00.000Z",
              "acceptedAt": "2024-01-15T09:30:00.000Z",
              "rejectedAt": "2024-01-15T09:30:00.000Z",
              "checkedAt": "2024-01-15T09:30:00.000Z",
              "nextCheckAt": "2024-01-15T09:30:00.000Z",
              "attempts": 1000000,
              "deliveryError": "deliveryError",
              "sentSha256": "sentSha256",
              "certificateFingerprint": "certificateFingerprint",
              "submittedByActorType": "submittedByActorType",
              "submittedByActorId": "submittedByActorId",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z",
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/create")
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

        var response = await Client.Declarations.SubmissionsCreateAsync(
            new SubmissionsCreateDeclarationsRequest
            {
                Obligation = SubmissionsCreateDeclarationsRequestObligation.LtIsaf,
                Year = 1000000,
                Month = 1000000,
                DataType = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "obligation": "lt-isaf",
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "obligation": "obligation",
              "periodYear": 1000000,
              "periodMonth": 1000000,
              "variant": "variant",
              "status": "generated",
              "fileName": "fileName",
              "fileId": "fileId",
              "externalRef": "externalRef",
              "message": "message",
              "ruleKey": "ruleKey",
              "period": "period",
              "documentKey": "documentKey",
              "amendment": 1000000,
              "origin": "origin",
              "transportSystem": "transportSystem",
              "environment": "test",
              "submittedAt": "2026-07-01T09:30:00.000Z",
              "acceptedAt": "2026-07-01T09:30:00.000Z",
              "rejectedAt": "2026-07-01T09:30:00.000Z",
              "checkedAt": "2026-07-01T09:30:00.000Z",
              "nextCheckAt": "2026-07-01T09:30:00.000Z",
              "attempts": 1000000,
              "deliveryError": "deliveryError",
              "sentSha256": "sentSha256",
              "certificateFingerprint": "certificateFingerprint",
              "submittedByActorType": "submittedByActorType",
              "submittedByActorId": "submittedByActorId",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/create")
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

        var response = await Client.Declarations.SubmissionsCreateAsync(
            new SubmissionsCreateDeclarationsRequest
            {
                Obligation = SubmissionsCreateDeclarationsRequestObligation.LtIsaf,
                Year = 1000000,
                Month = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
