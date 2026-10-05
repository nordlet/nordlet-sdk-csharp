using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StockTakeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "warehouseId": "x",
              "date": "2023-01-15",
              "lines": [
                {
                  "countedQty": "countedQty"
                },
                {
                  "countedQty": "countedQty"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "itemId": "x",
                  "onHand": "onHand",
                  "counted": "counted",
                  "difference": "difference",
                  "adjustmentCost": "adjustmentCost"
                },
                {
                  "itemId": "x",
                  "onHand": "onHand",
                  "counted": "counted",
                  "difference": "difference",
                  "adjustmentCost": "adjustmentCost"
                }
              ],
              "journalTransactionId": "x"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/take")
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

        var response = await Client.Inventory.StockTakeAsync(
            new StockTakeInventoryRequest
            {
                WarehouseId = "x",
                Date = new DateOnly(2023, 1, 15),
                ExpenseAccountCode = null,
                InventoryAccountCode = null,
                Lines = new List<StockTakeInventoryRequestLinesItem>()
                {
                    new StockTakeInventoryRequestLinesItem
                    {
                        ItemId = null,
                        Barcode = null,
                        CountedQty = "countedQty",
                        UnitCost = null,
                        LotNumber = null,
                        ExpiryDate = null,
                    },
                    new StockTakeInventoryRequestLinesItem
                    {
                        ItemId = null,
                        Barcode = null,
                        CountedQty = "countedQty",
                        UnitCost = null,
                        LotNumber = null,
                        ExpiryDate = null,
                    },
                },
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
              "date": "2026-07-01",
              "lines": [
                {
                  "countedQty": "121.0000"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "itemId": "itemId",
                  "onHand": "onHand",
                  "counted": "counted",
                  "difference": "difference",
                  "adjustmentCost": "adjustmentCost"
                }
              ],
              "journalTransactionId": "journalTransactionId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/stock/take")
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

        var response = await Client.Inventory.StockTakeAsync(
            new StockTakeInventoryRequest
            {
                WarehouseId = "warehouseId",
                Date = new DateOnly(2026, 7, 1),
                Lines = new List<StockTakeInventoryRequestLinesItem>()
                {
                    new StockTakeInventoryRequestLinesItem { CountedQty = "121.0000" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
