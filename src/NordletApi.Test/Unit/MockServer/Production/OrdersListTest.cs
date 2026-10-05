using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OrdersListTest : BaseMockServerTest
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
                  "type": "assembly",
                  "bomId": "x",
                  "warehouseId": "x",
                  "routingId": "x",
                  "quantity": "quantity",
                  "date": "2023-01-15",
                  "status": "draft",
                  "scrappedQuantity": "scrappedQuantity",
                  "materialCost": "materialCost",
                  "laborCost": "laborCost",
                  "scrapCost": "scrapCost",
                  "totalCost": "totalCost",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "type": "assembly",
                  "bomId": "x",
                  "warehouseId": "x",
                  "routingId": "x",
                  "quantity": "quantity",
                  "date": "2023-01-15",
                  "status": "draft",
                  "scrappedQuantity": "scrappedQuantity",
                  "materialCost": "materialCost",
                  "laborCost": "laborCost",
                  "scrapCost": "scrapCost",
                  "totalCost": "totalCost",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "2024-01-15T09:30:00.000Z"
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
                    .WithPath("/v1/production/orders/list")
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

        var response = await Client.Production.OrdersListAsync(
            new OrdersListProductionRequest
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
                  "type": "assembly",
                  "bomId": "bomId",
                  "warehouseId": "warehouseId",
                  "routingId": "routingId",
                  "quantity": "quantity",
                  "date": "2026-07-01",
                  "status": "draft",
                  "scrappedQuantity": "scrappedQuantity",
                  "materialCost": "materialCost",
                  "laborCost": "laborCost",
                  "scrapCost": "scrapCost",
                  "totalCost": "totalCost",
                  "journalTransactionId": "journalTransactionId",
                  "notes": "notes",
                  "createdAt": "2026-07-01T09:30:00.000Z"
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
                    .WithPath("/v1/production/orders/list")
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

        var response = await Client.Production.OrdersListAsync(new OrdersListProductionRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
