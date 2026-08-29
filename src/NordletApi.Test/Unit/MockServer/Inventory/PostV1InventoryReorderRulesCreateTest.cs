using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryReorderRulesCreateTest : BaseMockServerTest
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
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
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

        var response = await Client.Inventory.PostV1InventoryReorderRulesCreateAsync(
            new PostV1InventoryReorderRulesCreateRequest
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
              "minQty": "minQty"
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
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
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

        var response = await Client.Inventory.PostV1InventoryReorderRulesCreateAsync(
            new PostV1InventoryReorderRulesCreateRequest { ItemId = "itemId", MinQty = "minQty" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
