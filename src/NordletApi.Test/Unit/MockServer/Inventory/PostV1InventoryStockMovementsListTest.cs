using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryStockMovementsListTest : BaseMockServerTest
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
                  "warehouseId": "x",
                  "itemId": "x",
                  "lotId": "x",
                  "date": "date",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "notes": "notes",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "warehouseId": "x",
                  "itemId": "x",
                  "lotId": "x",
                  "date": "date",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
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
                    .WithPath("/v1/inventory/stock/movements/list")
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

        var response = await Client.Inventory.PostV1InventoryStockMovementsListAsync(
            new PostV1InventoryStockMovementsListRequest
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
                  "warehouseId": "warehouseId",
                  "itemId": "itemId",
                  "lotId": "lotId",
                  "date": "date",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
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
                    .WithPath("/v1/inventory/stock/movements/list")
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

        var response = await Client.Inventory.PostV1InventoryStockMovementsListAsync(
            new PostV1InventoryStockMovementsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
