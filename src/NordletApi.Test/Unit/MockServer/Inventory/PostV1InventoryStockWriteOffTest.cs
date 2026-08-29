using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryStockWriteOffTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "warehouseId": "x",
              "itemId": "x",
              "date": "date",
              "quantity": "quantity"
            }
            """;

        const string mockResponse = """
            {
              "movementId": "x",
              "totalCost": "totalCost",
              "journalTransactionId": "x"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/write-off")
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

        var response = await Client.Inventory.PostV1InventoryStockWriteOffAsync(
            new PostV1InventoryStockWriteOffRequest
            {
                WarehouseId = "x",
                ItemId = "x",
                Date = "date",
                Quantity = "quantity",
                LotNumber = null,
                ExpenseAccountCode = null,
                InventoryAccountCode = null,
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
              "quantity": "quantity"
            }
            """;

        const string mockResponse = """
            {
              "movementId": "movementId",
              "totalCost": "totalCost",
              "journalTransactionId": "journalTransactionId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/write-off")
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

        var response = await Client.Inventory.PostV1InventoryStockWriteOffAsync(
            new PostV1InventoryStockWriteOffRequest
            {
                WarehouseId = "warehouseId",
                ItemId = "itemId",
                Date = "date",
                Quantity = "quantity",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
