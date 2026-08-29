using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryStockTakeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "warehouseId": "x",
              "date": "date",
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

        var response = await Client.Inventory.PostV1InventoryStockTakeAsync(
            new PostV1InventoryStockTakeRequest
            {
                WarehouseId = "x",
                Date = "date",
                ExpenseAccountCode = null,
                InventoryAccountCode = null,
                Lines = new List<PostV1InventoryStockTakeRequestLinesItem>()
                {
                    new PostV1InventoryStockTakeRequestLinesItem
                    {
                        ItemId = null,
                        Barcode = null,
                        CountedQty = "countedQty",
                        UnitCost = null,
                        LotNumber = null,
                        ExpiryDate = null,
                    },
                    new PostV1InventoryStockTakeRequestLinesItem
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
              "date": "date",
              "lines": [
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

        var response = await Client.Inventory.PostV1InventoryStockTakeAsync(
            new PostV1InventoryStockTakeRequest
            {
                WarehouseId = "warehouseId",
                Date = "date",
                Lines = new List<PostV1InventoryStockTakeRequestLinesItem>()
                {
                    new PostV1InventoryStockTakeRequestLinesItem { CountedQty = "countedQty" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
