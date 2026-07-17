using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryStockReceiveTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "warehouseId": "x",
              "itemId": "x",
              "date": "date",
              "quantity": "quantity",
              "unitCost": "unitCost"
            }
            """;

        const string mockResponse = """
            {
              "movementId": "x",
              "totalCost": "totalCost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/receive")
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

        var response = await Client.Inventory.PostV1InventoryStockReceiveAsync(
            new PostV1InventoryStockReceiveRequest
            {
                WarehouseId = "x",
                ItemId = "x",
                Date = "date",
                Quantity = "quantity",
                UnitCost = "unitCost",
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "warehouseId": "warehouseId",
              "itemId": "itemId",
              "date": "date",
              "quantity": "quantity",
              "unitCost": "unitCost"
            }
            """;

        const string mockResponse = """
            {
              "movementId": "movementId",
              "totalCost": "totalCost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/receive")
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

        var response = await Client.Inventory.PostV1InventoryStockReceiveAsync(
            new PostV1InventoryStockReceiveRequest
            {
                WarehouseId = "warehouseId",
                ItemId = "itemId",
                Date = "date",
                Quantity = "quantity",
                UnitCost = "unitCost",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
