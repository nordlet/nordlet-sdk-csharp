using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CatalogPriceListsItemsSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "priceListId": "x",
              "items": [
                {
                  "itemId": "x",
                  "unitPriceExclVat": "unitPriceExclVat"
                },
                {
                  "itemId": "x",
                  "unitPriceExclVat": "unitPriceExclVat"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "updated": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/price-lists/items/set")
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

        var response = await Client.Catalog.PostV1CatalogPriceListsItemsSetAsync(
            new PostV1CatalogPriceListsItemsSetRequest
            {
                PriceListId = "x",
                Items = new List<PostV1CatalogPriceListsItemsSetRequestItemsItem>()
                {
                    new PostV1CatalogPriceListsItemsSetRequestItemsItem
                    {
                        ItemId = "x",
                        UnitPriceExclVat = "unitPriceExclVat",
                    },
                    new PostV1CatalogPriceListsItemsSetRequestItemsItem
                    {
                        ItemId = "x",
                        UnitPriceExclVat = "unitPriceExclVat",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "priceListId": "priceListId",
              "items": [
                {
                  "itemId": "itemId",
                  "unitPriceExclVat": "unitPriceExclVat"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "updated": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/price-lists/items/set")
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

        var response = await Client.Catalog.PostV1CatalogPriceListsItemsSetAsync(
            new PostV1CatalogPriceListsItemsSetRequest
            {
                PriceListId = "priceListId",
                Items = new List<PostV1CatalogPriceListsItemsSetRequestItemsItem>()
                {
                    new PostV1CatalogPriceListsItemsSetRequestItemsItem
                    {
                        ItemId = "itemId",
                        UnitPriceExclVat = "unitPriceExclVat",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
