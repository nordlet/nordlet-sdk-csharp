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
                  "documentRef": "documentRef",
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
                  "kindId": "x",
                  "saleAccountCode": "saleAccountCode",
                  "purchaseAccountCode": "purchaseAccountCode",
                  "expenseAccountCode": "expenseAccountCode",
                  "manufacturer": "manufacturer",
                  "grossMassKg": "grossMassKg",
                  "minQuantity": "minQuantity",
                  "costPrice": "costPrice",
                  "isFreePrice": true,
                  "externalId": "externalId",
                  "isReturnable": true,
                  "commentRequired": true,
                  "priceFrom": "priceFrom",
                  "priceTo": "priceTo",
                  "minPrice": "minPrice",
                  "discountPercent": "discountPercent",
                  "maxDiscountPercent": "maxDiscountPercent",
                  "loyaltyPoints": 1000000,
                  "department": "department",
                  "ageRestriction": 1000000,
                  "packageQuantity": "packageQuantity",
                  "taraCode": "taraCode",
                  "certificateNumber": "certificateNumber",
                  "certificateDate": "certificateDate",
                  "validFrom": "validFrom",
                  "validTo": "validTo",
                  "posFlags": {
                    "posFlags": true
                  },
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
                  "documentRef": "documentRef",
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
                  "kindId": "x",
                  "saleAccountCode": "saleAccountCode",
                  "purchaseAccountCode": "purchaseAccountCode",
                  "expenseAccountCode": "expenseAccountCode",
                  "manufacturer": "manufacturer",
                  "grossMassKg": "grossMassKg",
                  "minQuantity": "minQuantity",
                  "costPrice": "costPrice",
                  "isFreePrice": true,
                  "externalId": "externalId",
                  "isReturnable": true,
                  "commentRequired": true,
                  "priceFrom": "priceFrom",
                  "priceTo": "priceTo",
                  "minPrice": "minPrice",
                  "discountPercent": "discountPercent",
                  "maxDiscountPercent": "maxDiscountPercent",
                  "loyaltyPoints": 1000000,
                  "department": "department",
                  "ageRestriction": 1000000,
                  "packageQuantity": "packageQuantity",
                  "taraCode": "taraCode",
                  "certificateNumber": "certificateNumber",
                  "certificateDate": "certificateDate",
                  "validFrom": "validFrom",
                  "validTo": "validTo",
                  "posFlags": {
                    "posFlags": true
                  },
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
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
                Totals = null,
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
                  "documentRef": "documentRef",
                  "translations": {},
                  "components": [
                    {
                      "itemId": "itemId",
                      "itemName": "itemName",
                      "quantity": "quantity"
                    }
                  ],
                  "kindId": "kindId",
                  "saleAccountCode": "saleAccountCode",
                  "purchaseAccountCode": "purchaseAccountCode",
                  "expenseAccountCode": "expenseAccountCode",
                  "manufacturer": "manufacturer",
                  "grossMassKg": "grossMassKg",
                  "minQuantity": "minQuantity",
                  "costPrice": "costPrice",
                  "isFreePrice": true,
                  "externalId": "externalId",
                  "isReturnable": true,
                  "commentRequired": true,
                  "priceFrom": "priceFrom",
                  "priceTo": "priceTo",
                  "minPrice": "minPrice",
                  "discountPercent": "discountPercent",
                  "maxDiscountPercent": "maxDiscountPercent",
                  "loyaltyPoints": 1000000,
                  "department": "department",
                  "ageRestriction": 1000000,
                  "packageQuantity": "packageQuantity",
                  "taraCode": "taraCode",
                  "certificateNumber": "certificateNumber",
                  "certificateDate": "certificateDate",
                  "validFrom": "validFrom",
                  "validTo": "validTo",
                  "posFlags": {},
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
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
