using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Catalog;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CatalogItemsUpdateTest : BaseMockServerTest
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/update")
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

        var response = await Client.Catalog.PostV1CatalogItemsUpdateAsync(
            new PostV1CatalogItemsUpdateRequest
            {
                Id = "x",
                Type = null,
                Tracking = null,
                Name = null,
                Code = null,
                Barcode = null,
                Unit = null,
                VatClassifierCode = null,
                VatRatePercent = null,
                SalePriceExclVat = null,
                PurchasePriceExclVat = null,
                CnCode = null,
                OriginCountry = null,
                NetMassKg = null,
                SupplementaryUnit = null,
                SupplementaryQtyPerUnit = null,
                Description = null,
                GroupId = null,
                Attributes = null,
                DocumentRef = null,
                Translations = null,
                Components = null,
                KindId = null,
                SaleAccountCode = null,
                PurchaseAccountCode = null,
                ExpenseAccountCode = null,
                Manufacturer = null,
                GrossMassKg = null,
                MinQuantity = null,
                CostPrice = null,
                IsFreePrice = null,
                ExternalId = null,
                IsReturnable = null,
                CommentRequired = null,
                PriceFrom = null,
                PriceTo = null,
                MinPrice = null,
                DiscountPercent = null,
                MaxDiscountPercent = null,
                LoyaltyPoints = null,
                Department = null,
                AgeRestriction = null,
                PackageQuantity = null,
                TaraCode = null,
                CertificateNumber = null,
                CertificateDate = null,
                ValidFrom = null,
                ValidTo = null,
                PosFlags = null,
            }
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
              "attributes": {
                "key": "value"
              },
              "documentRef": "documentRef",
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
              "posFlags": {
                "key": true
              },
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/catalog/items/update")
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

        var response = await Client.Catalog.PostV1CatalogItemsUpdateAsync(
            new PostV1CatalogItemsUpdateRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
