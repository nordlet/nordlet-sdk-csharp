using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1EcommerceStockListTest : BaseMockServerTest
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
                  "itemId": "x",
                  "warehouseId": "x",
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "available": "available"
                },
                {
                  "itemId": "x",
                  "warehouseId": "x",
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
                    .WithPath("/v1/ecommerce/stock/list")
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

        var response = await Client.Ecommerce.PostV1EcommerceStockListAsync(
            new PostV1EcommerceStockListRequest { WarehouseId = null }
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
                  "itemId": "itemId",
                  "warehouseId": "warehouseId",
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
                    .WithPath("/v1/ecommerce/stock/list")
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

        var response = await Client.Ecommerce.PostV1EcommerceStockListAsync(
            new PostV1EcommerceStockListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
