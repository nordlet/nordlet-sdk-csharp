using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItemsSuppliersListTest : BaseMockServerTest
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
                  "id": "x",
                  "itemId": "x",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "supplierCode": "supplierCode",
                  "purchasePriceExclVat": "purchasePriceExclVat",
                  "currency": "currency",
                  "notes": "notes",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "supplierCode": "supplierCode",
                  "purchasePriceExclVat": "purchasePriceExclVat",
                  "currency": "currency",
                  "notes": "notes",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/suppliers/list")
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

        var response = await Client.Catalog.ItemsSuppliersListAsync(
            new ItemsSuppliersListCatalogRequest { ItemId = null, PartnerId = null }
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
                  "id": "id",
                  "itemId": "itemId",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "supplierCode": "supplierCode",
                  "purchasePriceExclVat": "purchasePriceExclVat",
                  "currency": "currency",
                  "notes": "notes",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/suppliers/list")
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

        var response = await Client.Catalog.ItemsSuppliersListAsync(
            new ItemsSuppliersListCatalogRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
