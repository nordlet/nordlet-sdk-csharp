using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SendAFilingWhoseDeliveryFailedOnceMoreWithTheBytesThatWereGeneratedTest
    : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
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
              "origin": "origin",
              "transportSystem": "transportSystem",
              "submittedAt": "submittedAt",
              "acceptedAt": "acceptedAt",
              "rejectedAt": "rejectedAt",
              "checkedAt": "checkedAt",
              "nextCheckAt": "nextCheckAt",
              "attempts": 1000000,
              "deliveryError": "deliveryError",
              "sentSha256": "sentSha256",
              "certificateFingerprint": "certificateFingerprint",
              "submittedByActorType": "submittedByActorType",
              "submittedByActorId": "submittedByActorId",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/retry")
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

        var response =
            await Client.Declarations.SendAFilingWhoseDeliveryFailedOnceMoreWithTheBytesThatWereGeneratedAsync(
                new PostV1DeclarationsSubmissionsRetryRequest { Id = "x" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
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
              "origin": "origin",
              "transportSystem": "transportSystem",
              "submittedAt": "submittedAt",
              "acceptedAt": "acceptedAt",
              "rejectedAt": "rejectedAt",
              "checkedAt": "checkedAt",
              "nextCheckAt": "nextCheckAt",
              "attempts": 1000000,
              "deliveryError": "deliveryError",
              "sentSha256": "sentSha256",
              "certificateFingerprint": "certificateFingerprint",
              "submittedByActorType": "submittedByActorType",
              "submittedByActorId": "submittedByActorId",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/retry")
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

        var response =
            await Client.Declarations.SendAFilingWhoseDeliveryFailedOnceMoreWithTheBytesThatWereGeneratedAsync(
                new PostV1DeclarationsSubmissionsRetryRequest { Id = "id" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
