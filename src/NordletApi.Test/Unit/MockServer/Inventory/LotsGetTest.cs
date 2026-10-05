using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LotsGetTest : BaseMockServerTest
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
              "itemId": "x",
              "lotNumber": "lotNumber",
              "expiryDate": "2023-01-15",
              "notes": "notes",
              "onHand": "onHand",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "movements": [
                {
                  "id": "x",
                  "warehouseId": "x",
                  "itemId": "x",
                  "lotId": "x",
                  "date": "2023-01-15",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "notes": "notes",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "warehouseId": "x",
                  "itemId": "x",
                  "lotId": "x",
                  "date": "2023-01-15",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "notes": "notes",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/lots/get")
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

        var response = await Client.Inventory.LotsGetAsync(
            new LotsGetInventoryRequest { Id = "x" }
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
              "itemId": "itemId",
              "lotNumber": "lotNumber",
              "expiryDate": "2026-07-01",
              "notes": "notes",
              "onHand": "onHand",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "movements": [
                {
                  "id": "id",
                  "warehouseId": "warehouseId",
                  "itemId": "itemId",
                  "lotId": "lotId",
                  "date": "2026-07-01",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "notes": "notes",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/lots/get")
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

        var response = await Client.Inventory.LotsGetAsync(
            new LotsGetInventoryRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
