using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryLandedCostsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "date": "date",
              "amount": "amount"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "date": "date",
              "amount": "amount",
              "method": "by_value",
              "goodsReceiptId": "goodsReceiptId",
              "sourceInvoiceId": "sourceInvoiceId",
              "notes": "notes",
              "createdAt": "createdAt",
              "lines": [
                {
                  "movementId": "x",
                  "allocatedAmount": "allocatedAmount",
                  "newUnitCost": "newUnitCost"
                },
                {
                  "movementId": "x",
                  "allocatedAmount": "allocatedAmount",
                  "newUnitCost": "newUnitCost"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/landed-costs/create")
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

        var response = await Client.Inventory.PostV1InventoryLandedCostsCreateAsync(
            new PostV1InventoryLandedCostsCreateRequest
            {
                Date = "date",
                Amount = "amount",
                Method = null,
                GoodsReceiptId = null,
                MovementIds = null,
                SourceInvoiceId = null,
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
              "date": "date",
              "amount": "amount"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "date": "date",
              "amount": "amount",
              "method": "by_value",
              "goodsReceiptId": "goodsReceiptId",
              "sourceInvoiceId": "sourceInvoiceId",
              "notes": "notes",
              "createdAt": "createdAt",
              "lines": [
                {
                  "movementId": "movementId",
                  "allocatedAmount": "allocatedAmount",
                  "newUnitCost": "newUnitCost"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/landed-costs/create")
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

        var response = await Client.Inventory.PostV1InventoryLandedCostsCreateAsync(
            new PostV1InventoryLandedCostsCreateRequest { Date = "date", Amount = "amount" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
