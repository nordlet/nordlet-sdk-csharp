using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItemsUnitsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "itemId": "x",
              "unitCode": "x",
              "factor": "factor"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "itemId": "x",
              "unitCode": "unitCode",
              "factor": "factor",
              "isDefaultSale": true,
              "isDefaultPurchase": true,
              "barcode": "barcode",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/units/create")
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

        var response = await Client.Catalog.ItemsUnitsCreateAsync(
            new ItemsUnitsCreateCatalogRequest
            {
                ItemId = "x",
                UnitCode = "x",
                Factor = "factor",
                IsDefaultSale = null,
                IsDefaultPurchase = null,
                Barcode = null,
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
              "unitCode": "unitCode",
              "factor": "121.000000"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "itemId": "itemId",
              "unitCode": "unitCode",
              "factor": "factor",
              "isDefaultSale": true,
              "isDefaultPurchase": true,
              "barcode": "barcode",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/units/create")
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

        var response = await Client.Catalog.ItemsUnitsCreateAsync(
            new ItemsUnitsCreateCatalogRequest
            {
                ItemId = "itemId",
                UnitCode = "unitCode",
                Factor = "121.000000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
