using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionQualityChecksListTest : BaseMockServerTest
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
                  "orderId": "x",
                  "routingOperationId": "x",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "checkedAt",
                  "checkedBy": "checkedBy",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "orderId": "x",
                  "routingOperationId": "x",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "checkedAt",
                  "checkedBy": "checkedBy",
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
                    .WithPath("/v1/production/quality-checks/list")
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

        var response = await Client.Production.PostV1ProductionQualityChecksListAsync(
            new PostV1ProductionQualityChecksListRequest
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
                  "orderId": "orderId",
                  "routingOperationId": "routingOperationId",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "checkedAt",
                  "checkedBy": "checkedBy",
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
                    .WithPath("/v1/production/quality-checks/list")
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

        var response = await Client.Production.PostV1ProductionQualityChecksListAsync(
            new PostV1ProductionQualityChecksListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
