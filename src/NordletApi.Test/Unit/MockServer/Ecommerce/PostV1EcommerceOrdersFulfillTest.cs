using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1EcommerceOrdersFulfillTest : BaseMockServerTest
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
              "channel": "channel",
              "externalRef": "externalRef",
              "partnerId": "x",
              "warehouseId": "x",
              "currency": "currency",
              "status": "new",
              "invoiceId": "x",
              "shipToCountryCode": "shipToCountryCode",
              "marketplace": "marketplace",
              "notes": "notes",
              "createdAt": "createdAt",
              "lines": [
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "vatRatePercent": "vatRatePercent"
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "vatRatePercent": "vatRatePercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ecommerce/orders/fulfill")
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

        var response = await Client.Ecommerce.PostV1EcommerceOrdersFulfillAsync(
            new PostV1EcommerceOrdersFulfillRequest
            {
                Id = "x",
                Date = null,
                CogsAccountCode = null,
                InventoryAccountCode = null,
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
              "channel": "channel",
              "externalRef": "externalRef",
              "partnerId": "partnerId",
              "warehouseId": "warehouseId",
              "currency": "currency",
              "status": "new",
              "invoiceId": "invoiceId",
              "shipToCountryCode": "shipToCountryCode",
              "marketplace": "marketplace",
              "notes": "notes",
              "createdAt": "createdAt",
              "lines": [
                {
                  "id": "id",
                  "itemId": "itemId",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "vatRatePercent": "vatRatePercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ecommerce/orders/fulfill")
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

        var response = await Client.Ecommerce.PostV1EcommerceOrdersFulfillAsync(
            new PostV1EcommerceOrdersFulfillRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
