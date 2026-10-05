using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReorderRulesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "itemId": "x",
              "minQty": "minQty"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "itemId": "x",
              "warehouseId": "x",
              "minQty": "minQty",
              "reorderQty": "reorderQty",
              "isActive": true,
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/reorder-rules/create")
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

        var response = await Client.Inventory.ReorderRulesCreateAsync(
            new ReorderRulesCreateInventoryRequest
            {
                ItemId = "x",
                WarehouseId = null,
                MinQty = "minQty",
                ReorderQty = null,
                IsActive = null,
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
              "itemId": "itemId",
              "minQty": "121.0000"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "itemId": "itemId",
              "warehouseId": "warehouseId",
              "minQty": "minQty",
              "reorderQty": "reorderQty",
              "isActive": true,
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/reorder-rules/create")
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

        var response = await Client.Inventory.ReorderRulesCreateAsync(
            new ReorderRulesCreateInventoryRequest { ItemId = "itemId", MinQty = "121.0000" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
