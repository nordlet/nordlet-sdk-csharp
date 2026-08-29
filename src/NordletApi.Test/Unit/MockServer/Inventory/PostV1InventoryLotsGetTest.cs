using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryLotsGetTest : BaseMockServerTest
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
              "expiryDate": "expiryDate",
              "notes": "notes",
              "onHand": "onHand",
              "createdAt": "createdAt",
              "movements": [
                {
                  "id": "x",
                  "warehouseId": "x",
                  "itemId": "x",
                  "lotId": "x",
                  "date": "date",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "notes": "notes",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "warehouseId": "x",
                  "itemId": "x",
                  "lotId": "x",
                  "date": "date",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "notes": "notes",
                  "createdAt": "createdAt"
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

        var response = await Client.Inventory.PostV1InventoryLotsGetAsync(
            new PostV1InventoryLotsGetRequest { Id = "x" }
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
              "expiryDate": "expiryDate",
              "notes": "notes",
              "onHand": "onHand",
              "createdAt": "createdAt",
              "movements": [
                {
                  "id": "id",
                  "warehouseId": "warehouseId",
                  "itemId": "itemId",
                  "lotId": "lotId",
                  "date": "date",
                  "direction": "in",
                  "quantity": "quantity",
                  "unitCost": "unitCost",
                  "totalCost": "totalCost",
                  "remainingQty": "remainingQty",
                  "documentType": "documentType",
                  "documentId": "documentId",
                  "notes": "notes",
                  "createdAt": "createdAt"
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

        var response = await Client.Inventory.PostV1InventoryLotsGetAsync(
            new PostV1InventoryLotsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
