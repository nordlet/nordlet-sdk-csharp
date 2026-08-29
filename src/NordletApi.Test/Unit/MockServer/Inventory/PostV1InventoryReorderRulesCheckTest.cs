using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Inventory;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1InventoryReorderRulesCheckTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "ruleId": "x",
                  "itemId": "x",
                  "warehouseId": "x",
                  "minQty": "minQty",
                  "reorderQty": "reorderQty",
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "available": "available"
                },
                {
                  "ruleId": "x",
                  "itemId": "x",
                  "warehouseId": "x",
                  "minQty": "minQty",
                  "reorderQty": "reorderQty",
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "available": "available"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/reorder-rules/check")
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

        var response = await Client.Inventory.PostV1InventoryReorderRulesCheckAsync(
            new PostV1InventoryReorderRulesCheckRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "ruleId": "ruleId",
                  "itemId": "itemId",
                  "warehouseId": "warehouseId",
                  "minQty": "minQty",
                  "reorderQty": "reorderQty",
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "available": "available"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/inventory/reorder-rules/check")
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

        var response = await Client.Inventory.PostV1InventoryReorderRulesCheckAsync(
            new PostV1InventoryReorderRulesCheckRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
