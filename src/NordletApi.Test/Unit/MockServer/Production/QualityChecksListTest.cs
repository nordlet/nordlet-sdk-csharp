using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class QualityChecksListTest : BaseMockServerTest
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
                  "checkedAt": "2024-01-15T09:30:00.000Z",
                  "checkedBy": "checkedBy",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "orderId": "x",
                  "routingOperationId": "x",
                  "name": "name",
                  "result": "pending",
                  "notes": "notes",
                  "checkedAt": "2024-01-15T09:30:00.000Z",
                  "checkedBy": "checkedBy",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
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

        var response = await Client.Production.QualityChecksListAsync(
            new QualityChecksListProductionRequest
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
                  "checkedAt": "2026-07-01T09:30:00.000Z",
                  "checkedBy": "checkedBy",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
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

        var response = await Client.Production.QualityChecksListAsync(
            new QualityChecksListProductionRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
