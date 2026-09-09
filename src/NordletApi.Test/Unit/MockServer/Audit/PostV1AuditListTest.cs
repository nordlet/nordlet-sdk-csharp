using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Audit;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AuditListTest : BaseMockServerTest
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
                  "id": 1000000,
                  "actorType": "user",
                  "actorId": "actorId",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "diff": {
                    "key": "value"
                  },
                  "createdAt": "createdAt"
                },
                {
                  "id": 1000000,
                  "actorType": "user",
                  "actorId": "actorId",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "diff": {
                    "key": "value"
                  },
                  "createdAt": "createdAt"
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
                    .WithPath("/v1/audit/list")
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

        var response = await Client.Audit.PostV1AuditListAsync(
            new PostV1AuditListRequest
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
                  "id": 1000000,
                  "actorType": "user",
                  "actorId": "actorId",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "diff": {
                    "key": "value"
                  },
                  "createdAt": "createdAt"
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
                    .WithPath("/v1/audit/list")
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

        var response = await Client.Audit.PostV1AuditListAsync(new PostV1AuditListRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
