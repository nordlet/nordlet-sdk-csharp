using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CatalogItemsSuppliersListTest : BaseMockServerTest
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
                  "updatedAt": "updatedAt"
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
                  "updatedAt": "updatedAt"
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

        var response = await Client.Catalog.PostV1CatalogItemsSuppliersListAsync(
            new PostV1CatalogItemsSuppliersListRequest { ItemId = null, PartnerId = null }
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
                  "updatedAt": "updatedAt"
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

        var response = await Client.Catalog.PostV1CatalogItemsSuppliersListAsync(
            new PostV1CatalogItemsSuppliersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
