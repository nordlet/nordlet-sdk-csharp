using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CatalogItemsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "type": "product",
              "name": "name",
              "code": "code",
              "barcode": "barcode",
              "unit": "unit",
              "vatClassifierCode": "vatClassifierCode",
              "vatRatePercent": "vatRatePercent",
              "salePriceExclVat": "salePriceExclVat",
              "purchasePriceExclVat": "purchasePriceExclVat",
              "cnCode": "cnCode",
              "originCountry": "originCountry",
              "netMassKg": "netMassKg",
              "supplementaryUnit": "supplementaryUnit",
              "supplementaryQtyPerUnit": "supplementaryQtyPerUnit",
              "description": "description",
              "groupId": "x",
              "attributes": {
                "attributes": "attributes"
              },
              "translations": {
                "translations": {
                  "name": "name",
                  "description": "description"
                }
              },
              "components": [
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "quantity": "quantity"
                },
                {
                  "itemId": "x",
                  "itemName": "itemName",
                  "quantity": "quantity"
                }
              ],
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/get")
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

        var response = await Client.Catalog.PostV1CatalogItemsGetAsync(
            new PostV1CatalogItemsGetRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "type": "product",
              "name": "name",
              "code": "code",
              "barcode": "barcode",
              "unit": "unit",
              "vatClassifierCode": "vatClassifierCode",
              "vatRatePercent": "vatRatePercent",
              "salePriceExclVat": "salePriceExclVat",
              "purchasePriceExclVat": "purchasePriceExclVat",
              "cnCode": "cnCode",
              "originCountry": "originCountry",
              "netMassKg": "netMassKg",
              "supplementaryUnit": "supplementaryUnit",
              "supplementaryQtyPerUnit": "supplementaryQtyPerUnit",
              "description": "description",
              "groupId": "groupId",
              "attributes": {
                "key": "value"
              },
              "translations": {
                "key": {
                  "name": "name",
                  "description": "description"
                }
              },
              "components": [
                {
                  "itemId": "itemId",
                  "itemName": "itemName",
                  "quantity": "quantity"
                }
              ],
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/get")
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

        var response = await Client.Catalog.PostV1CatalogItemsGetAsync(
            new PostV1CatalogItemsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
