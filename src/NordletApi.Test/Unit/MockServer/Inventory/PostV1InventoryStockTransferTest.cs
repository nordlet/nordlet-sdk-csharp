using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryStockTransferTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromWarehouseId": "x",
              "toWarehouseId": "x",
              "itemId": "x",
              "date": "date",
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

        var response = await Client.Inventory.PostV1InventoryStockTransferAsync(
            new PostV1InventoryStockTransferRequest
            {
                FromWarehouseId = "x",
                ToWarehouseId = "x",
                ItemId = "x",
                Date = "date",
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
              "date": "date",
              "quantity": "quantity"
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

        var response = await Client.Inventory.PostV1InventoryStockTransferAsync(
            new PostV1InventoryStockTransferRequest
            {
                FromWarehouseId = "fromWarehouseId",
                ToWarehouseId = "toWarehouseId",
                ItemId = "itemId",
                Date = "date",
                Quantity = "quantity",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
