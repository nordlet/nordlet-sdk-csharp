using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StockWriteOffTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "warehouseId": "x",
              "itemId": "x",
              "date": "2023-01-15",
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

        var response = await Client.Inventory.StockWriteOffAsync(
            new StockWriteOffInventoryRequest
            {
                WarehouseId = "x",
                ItemId = "x",
                Date = new DateOnly(2023, 1, 15),
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
              "date": "2026-07-01",
              "quantity": "121.0000"
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

        var response = await Client.Inventory.StockWriteOffAsync(
            new StockWriteOffInventoryRequest
            {
                WarehouseId = "warehouseId",
                ItemId = "itemId",
                Date = new DateOnly(2026, 7, 1),
                Quantity = "121.0000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
