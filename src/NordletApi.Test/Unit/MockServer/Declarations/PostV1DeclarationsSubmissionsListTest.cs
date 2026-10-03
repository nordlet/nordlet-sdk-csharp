using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsSubmissionsListTest : BaseMockServerTest
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
                },
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/list")
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

        var response = await Client.Declarations.PostV1DeclarationsSubmissionsListAsync(
            new PostV1DeclarationsSubmissionsListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
            }
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/submissions/list")
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

        var response = await Client.Declarations.PostV1DeclarationsSubmissionsListAsync(
            new PostV1DeclarationsSubmissionsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
