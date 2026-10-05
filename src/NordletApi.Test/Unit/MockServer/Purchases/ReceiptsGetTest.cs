using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Purchases;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReceiptsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "orderId": "x",
              "receiptNumber": "receiptNumber",
              "receiptDate": "2023-01-15",
              "warehouseId": "x",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
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
                    .WithPath("/v1/purchases/receipts/get")
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

        var response = await Client.Purchases.ReceiptsGetAsync(
            new ReceiptsGetPurchasesRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "orderId": "orderId",
              "receiptNumber": "receiptNumber",
              "receiptDate": "2026-07-01",
              "warehouseId": "warehouseId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
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
                    .WithPath("/v1/purchases/receipts/get")
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

        var response = await Client.Purchases.ReceiptsGetAsync(
            new ReceiptsGetPurchasesRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
