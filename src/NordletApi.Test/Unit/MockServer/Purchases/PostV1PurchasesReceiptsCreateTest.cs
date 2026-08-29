using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PurchasesReceiptsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "orderId": "x",
              "receiptDate": "receiptDate",
              "lines": [
                {
                  "orderLineId": "x",
                  "quantity": "quantity"
                },
                {
                  "orderLineId": "x",
                  "quantity": "quantity"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "orderId": "x",
              "receiptNumber": "receiptNumber",
              "receiptDate": "receiptDate",
              "warehouseId": "x",
              "notes": "notes",
              "createdAt": "createdAt",
              "lines": [
                {
                  "id": "x",
                  "orderLineId": "x",
                  "itemId": "x",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "stockMovementId": "x"
                },
                {
                  "id": "x",
                  "orderLineId": "x",
                  "itemId": "x",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "stockMovementId": "x"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/receipts/create")
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

        var response = await Client.Purchases.PostV1PurchasesReceiptsCreateAsync(
            new PostV1PurchasesReceiptsCreateRequest
            {
                OrderId = "x",
                ReceiptDate = "receiptDate",
                WarehouseId = null,
                Notes = null,
                Lines = new List<PostV1PurchasesReceiptsCreateRequestLinesItem>()
                {
                    new PostV1PurchasesReceiptsCreateRequestLinesItem
                    {
                        OrderLineId = "x",
                        Quantity = "quantity",
                        LotNumber = null,
                        ExpiryDate = null,
                    },
                    new PostV1PurchasesReceiptsCreateRequestLinesItem
                    {
                        OrderLineId = "x",
                        Quantity = "quantity",
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
              "orderId": "orderId",
              "receiptDate": "receiptDate",
              "lines": [
                {
                  "orderLineId": "orderLineId",
                  "quantity": "quantity"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "orderId": "orderId",
              "receiptNumber": "receiptNumber",
              "receiptDate": "receiptDate",
              "warehouseId": "warehouseId",
              "notes": "notes",
              "createdAt": "createdAt",
              "lines": [
                {
                  "id": "id",
                  "orderLineId": "orderLineId",
                  "itemId": "itemId",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "stockMovementId": "stockMovementId"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/purchases/receipts/create")
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

        var response = await Client.Purchases.PostV1PurchasesReceiptsCreateAsync(
            new PostV1PurchasesReceiptsCreateRequest
            {
                OrderId = "orderId",
                ReceiptDate = "receiptDate",
                Lines = new List<PostV1PurchasesReceiptsCreateRequestLinesItem>()
                {
                    new PostV1PurchasesReceiptsCreateRequestLinesItem
                    {
                        OrderLineId = "orderLineId",
                        Quantity = "quantity",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
