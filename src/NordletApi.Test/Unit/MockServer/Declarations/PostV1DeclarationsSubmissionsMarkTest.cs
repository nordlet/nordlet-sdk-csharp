using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsSubmissionsMarkTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "status": "submitted"
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
                    .WithPath("/v1/declarations/submissions/mark")
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

        var response = await Client.Declarations.PostV1DeclarationsSubmissionsMarkAsync(
            new PostV1DeclarationsSubmissionsMarkRequest
            {
                Id = "x",
                Status = PostV1DeclarationsSubmissionsMarkRequestStatus.Submitted,
                ExternalRef = null,
                Message = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "status": "submitted"
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
                    .WithPath("/v1/declarations/submissions/mark")
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

        var response = await Client.Declarations.PostV1DeclarationsSubmissionsMarkAsync(
            new PostV1DeclarationsSubmissionsMarkRequest
            {
                Id = "id",
                Status = PostV1DeclarationsSubmissionsMarkRequestStatus.Submitted,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
