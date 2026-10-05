using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StockTransferTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromWarehouseId": "x",
              "toWarehouseId": "x",
              "itemId": "x",
              "date": "2023-01-15",
              "quantity": "quantity"
            }
            """;

        const string mockResponse = """
            {
              "outMovementId": "x",
              "inMovementId": "x",
              "totalCost": "totalCost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/transfer")
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

        var response = await Client.Inventory.StockTransferAsync(
            new StockTransferInventoryRequest
            {
                FromWarehouseId = "x",
                ToWarehouseId = "x",
                ItemId = "x",
                Date = new DateOnly(2023, 1, 15),
                Quantity = "quantity",
                LotNumber = null,
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
              "fromWarehouseId": "fromWarehouseId",
              "toWarehouseId": "toWarehouseId",
              "itemId": "itemId",
              "date": "2026-07-01",
              "quantity": "121.0000"
            }
            """;

        const string mockResponse = """
            {
              "outMovementId": "outMovementId",
              "inMovementId": "inMovementId",
              "totalCost": "totalCost"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/transfer")
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

        var response = await Client.Inventory.StockTransferAsync(
            new StockTransferInventoryRequest
            {
                FromWarehouseId = "fromWarehouseId",
                ToWarehouseId = "toWarehouseId",
                ItemId = "itemId",
                Date = new DateOnly(2026, 7, 1),
                Quantity = "121.0000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
