using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CatalogItemsListTest : BaseMockServerTest
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
                  "type": "product",
                  "tracking": "none",
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
                },
                {
                  "id": "x",
                  "type": "product",
                  "tracking": "none",
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/list")
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

        var response = await Client.Catalog.PostV1CatalogItemsListAsync(
            new PostV1CatalogItemsListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
            }
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
                  "type": "product",
                  "tracking": "none",
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
                  "attributes": {},
                  "translations": {},
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/list")
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

        var response = await Client.Catalog.PostV1CatalogItemsListAsync(
            new PostV1CatalogItemsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
