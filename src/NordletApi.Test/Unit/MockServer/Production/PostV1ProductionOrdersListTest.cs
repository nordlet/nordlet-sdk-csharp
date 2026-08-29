using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Production;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProductionOrdersListTest : BaseMockServerTest
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
                  "date": "date",
                  "status": "draft",
                  "scrappedQuantity": "scrappedQuantity",
                  "materialCost": "materialCost",
                  "laborCost": "laborCost",
                  "scrapCost": "scrapCost",
                  "totalCost": "totalCost",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "type": "assembly",
                  "bomId": "x",
                  "warehouseId": "x",
                  "routingId": "x",
                  "quantity": "quantity",
                  "date": "date",
                  "status": "draft",
                  "scrappedQuantity": "scrappedQuantity",
                  "materialCost": "materialCost",
                  "laborCost": "laborCost",
                  "scrapCost": "scrapCost",
                  "totalCost": "totalCost",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
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

        var response = await Client.Production.PostV1ProductionOrdersListAsync(
            new PostV1ProductionOrdersListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
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
                  "date": "date",
                  "status": "draft",
                  "scrappedQuantity": "scrappedQuantity",
                  "materialCost": "materialCost",
                  "laborCost": "laborCost",
                  "scrapCost": "scrapCost",
                  "totalCost": "totalCost",
                  "journalTransactionId": "journalTransactionId",
                  "notes": "notes",
                  "createdAt": "createdAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
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

        var response = await Client.Production.PostV1ProductionOrdersListAsync(
            new PostV1ProductionOrdersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
