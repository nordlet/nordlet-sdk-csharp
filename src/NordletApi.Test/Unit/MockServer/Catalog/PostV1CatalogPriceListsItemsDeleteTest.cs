using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CatalogPriceListsItemsDeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "priceListId": "x",
              "itemId": "x"
            }
            """;

        const string mockResponse = """
            {
              "deleted": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/price-lists/items/delete")
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

        var response = await Client.Catalog.PostV1CatalogPriceListsItemsDeleteAsync(
            new PostV1CatalogPriceListsItemsDeleteRequest { PriceListId = "x", ItemId = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "priceListId": "priceListId",
              "itemId": "itemId"
            }
            """;

        const string mockResponse = """
            {
              "deleted": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/price-lists/items/delete")
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

        var response = await Client.Catalog.PostV1CatalogPriceListsItemsDeleteAsync(
            new PostV1CatalogPriceListsItemsDeleteRequest
            {
                PriceListId = "priceListId",
                ItemId = "itemId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
