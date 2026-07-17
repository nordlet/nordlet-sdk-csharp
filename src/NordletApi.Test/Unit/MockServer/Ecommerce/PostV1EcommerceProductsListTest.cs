using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1EcommerceProductsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "total": 1000000,
              "page": 1000000,
              "pageSize": 1000000,
              "rows": [
                {
                  "id": "x",
                  "type": "product",
                  "name": "name",
                  "code": "code",
                  "barcode": "barcode",
                  "unit": "unit",
                  "description": "description",
                  "translations": {
                    "translations": {
                      "name": "name",
                      "description": "description"
                    }
                  },
                  "attributes": {
                    "attributes": "attributes"
                  },
                  "groupId": "x",
                  "groupName": "groupName",
                  "vatRatePercent": "vatRatePercent",
                  "price": "price",
                  "currency": "currency",
                  "components": [
                    {
                      "itemId": "x",
                      "quantity": "quantity"
                    },
                    {
                      "itemId": "x",
                      "quantity": "quantity"
                    }
                  ],
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "available": "available",
                  "deleted": true,
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "type": "product",
                  "name": "name",
                  "code": "code",
                  "barcode": "barcode",
                  "unit": "unit",
                  "description": "description",
                  "translations": {
                    "translations": {
                      "name": "name",
                      "description": "description"
                    }
                  },
                  "attributes": {
                    "attributes": "attributes"
                  },
                  "groupId": "x",
                  "groupName": "groupName",
                  "vatRatePercent": "vatRatePercent",
                  "price": "price",
                  "currency": "currency",
                  "components": [
                    {
                      "itemId": "x",
                      "quantity": "quantity"
                    },
                    {
                      "itemId": "x",
                      "quantity": "quantity"
                    }
                  ],
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "available": "available",
                  "deleted": true,
                  "updatedAt": "updatedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ecommerce/products/list")
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

        var response = await Client.Ecommerce.PostV1EcommerceProductsListAsync(
            new PostV1EcommerceProductsListRequest
            {
                WarehouseId = null,
                PriceListId = null,
                UpdatedSince = null,
                Page = null,
                PageSize = null,
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
              "total": 1000000,
              "page": 1000000,
              "pageSize": 1000000,
              "rows": [
                {
                  "id": "id",
                  "type": "product",
                  "name": "name",
                  "code": "code",
                  "barcode": "barcode",
                  "unit": "unit",
                  "description": "description",
                  "translations": {},
                  "attributes": {},
                  "groupId": "groupId",
                  "groupName": "groupName",
                  "vatRatePercent": "vatRatePercent",
                  "price": "price",
                  "currency": "currency",
                  "components": [
                    {
                      "itemId": "itemId",
                      "quantity": "quantity"
                    }
                  ],
                  "onHand": "onHand",
                  "reserved": "reserved",
                  "available": "available",
                  "deleted": true,
                  "updatedAt": "updatedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ecommerce/products/list")
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

        var response = await Client.Ecommerce.PostV1EcommerceProductsListAsync(
            new PostV1EcommerceProductsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
