using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LandedCostsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "date": "2023-01-15",
              "amount": "amount"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "date": "2023-01-15",
              "amount": "amount",
              "method": "by_value",
              "goodsReceiptId": "goodsReceiptId",
              "sourceInvoiceId": "sourceInvoiceId",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "journalTransactionId": "x",
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

        var response = await Client.Inventory.LandedCostsCreateAsync(
            new LandedCostsCreateInventoryRequest
            {
                Date = new DateOnly(2023, 1, 15),
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
              "date": "2026-07-01",
              "amount": "121.000000"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "date": "2026-07-01",
              "amount": "amount",
              "method": "by_value",
              "goodsReceiptId": "goodsReceiptId",
              "sourceInvoiceId": "sourceInvoiceId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "journalTransactionId": "journalTransactionId",
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

        var response = await Client.Inventory.LandedCostsCreateAsync(
            new LandedCostsCreateInventoryRequest
            {
                Date = new DateOnly(2026, 7, 1),
                Amount = "121.000000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
