using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CatalogItemsSuppliersUpsertTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "itemId": "x",
              "partnerId": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/suppliers/upsert")
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

        var response = await Client.Catalog.PostV1CatalogItemsSuppliersUpsertAsync(
            new PostV1CatalogItemsSuppliersUpsertRequest
            {
                ItemId = "x",
                PartnerId = "x",
                SupplierCode = null,
                PurchasePriceExclVat = null,
                Currency = null,
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
              "partnerId": "partnerId"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/suppliers/upsert")
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

        var response = await Client.Catalog.PostV1CatalogItemsSuppliersUpsertAsync(
            new PostV1CatalogItemsSuppliersUpsertRequest
            {
                ItemId = "itemId",
                PartnerId = "partnerId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
