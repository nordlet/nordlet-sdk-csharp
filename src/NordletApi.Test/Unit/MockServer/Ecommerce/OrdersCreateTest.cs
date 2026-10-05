using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ecommerce;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OrdersCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "lines": [
                {
                  "description": "x",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat"
                },
                {
                  "description": "x",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat"
                }
              ]
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
              "createdAt": "2024-01-15T09:30:00.000Z",
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
                    .WithPath("/v1/ecommerce/orders/create")
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

        var response = await Client.Ecommerce.OrdersCreateAsync(
            new OrdersCreateEcommerceRequest
            {
                Channel = null,
                ExternalRef = null,
                PartnerId = null,
                Partner = null,
                WarehouseId = null,
                Currency = null,
                ShipToCountryCode = null,
                Marketplace = null,
                Notes = null,
                Lines = new List<OrdersCreateEcommerceRequestLinesItem>()
                {
                    new OrdersCreateEcommerceRequestLinesItem
                    {
                        ItemId = null,
                        Description = "x",
                        Quantity = "quantity",
                        UnitPriceExclVat = "unitPriceExclVat",
                        VatRatePercent = null,
                    },
                    new OrdersCreateEcommerceRequestLinesItem
                    {
                        ItemId = null,
                        Description = "x",
                        Quantity = "quantity",
                        UnitPriceExclVat = "unitPriceExclVat",
                        VatRatePercent = null,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "lines": [
                {
                  "description": "description",
                  "quantity": "121.0000",
                  "unitPriceExclVat": "121.0000"
                }
              ]
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
              "createdAt": "2026-07-01T09:30:00.000Z",
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
                    .WithPath("/v1/ecommerce/orders/create")
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

        var response = await Client.Ecommerce.OrdersCreateAsync(
            new OrdersCreateEcommerceRequest
            {
                Lines = new List<OrdersCreateEcommerceRequestLinesItem>()
                {
                    new OrdersCreateEcommerceRequestLinesItem
                    {
                        Description = "description",
                        Quantity = "121.0000",
                        UnitPriceExclVat = "121.0000",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
