using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoiceTemplatesListTest : BaseMockServerTest
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
                  "name": "name",
                  "documentType": "invoice",
                  "partnerId": "x",
                  "currency": "currency",
                  "paymentTermDays": 1000000,
                  "vatScheme": "vatScheme",
                  "vatCountryCode": "vatCountryCode",
                  "agreementId": "x",
                  "operationTypeId": "x",
                  "documentSeriesId": "x",
                  "discountPercent": "discountPercent",
                  "issuedByName": "issuedByName",
                  "issuedByTitle": "issuedByTitle",
                  "receivedByName": "receivedByName",
                  "receivedByTitle": "receivedByTitle",
                  "notes": "notes",
                  "supplyType": "goods",
                  "seriesLabel": "seriesLabel",
                  "orderNumber": "orderNumber",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "lines": [
                    {
                      "itemId": "x",
                      "description": "description",
                      "quantity": "quantity",
                      "unitPriceExclVat": "unitPriceExclVat",
                      "vatRatePercent": "vatRatePercent",
                      "vatExemptionBasis": "vatExemptionBasis",
                      "projectId": "x",
                      "unit": "unit"
                    },
                    {
                      "itemId": "x",
                      "description": "description",
                      "quantity": "quantity",
                      "unitPriceExclVat": "unitPriceExclVat",
                      "vatRatePercent": "vatRatePercent",
                      "vatExemptionBasis": "vatExemptionBasis",
                      "projectId": "x",
                      "unit": "unit"
                    }
                  ],
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "name": "name",
                  "documentType": "invoice",
                  "partnerId": "x",
                  "currency": "currency",
                  "paymentTermDays": 1000000,
                  "vatScheme": "vatScheme",
                  "vatCountryCode": "vatCountryCode",
                  "agreementId": "x",
                  "operationTypeId": "x",
                  "documentSeriesId": "x",
                  "discountPercent": "discountPercent",
                  "issuedByName": "issuedByName",
                  "issuedByTitle": "issuedByTitle",
                  "receivedByName": "receivedByName",
                  "receivedByTitle": "receivedByTitle",
                  "notes": "notes",
                  "supplyType": "goods",
                  "seriesLabel": "seriesLabel",
                  "orderNumber": "orderNumber",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "lines": [
                    {
                      "itemId": "x",
                      "description": "description",
                      "quantity": "quantity",
                      "unitPriceExclVat": "unitPriceExclVat",
                      "vatRatePercent": "vatRatePercent",
                      "vatExemptionBasis": "vatExemptionBasis",
                      "projectId": "x",
                      "unit": "unit"
                    },
                    {
                      "itemId": "x",
                      "description": "description",
                      "quantity": "quantity",
                      "unitPriceExclVat": "unitPriceExclVat",
                      "vatRatePercent": "vatRatePercent",
                      "vatExemptionBasis": "vatExemptionBasis",
                      "projectId": "x",
                      "unit": "unit"
                    }
                  ],
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoice-templates/list")
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

        var response = await Client.Sales.InvoiceTemplatesListAsync(
            new InvoiceTemplatesListSalesRequest
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
                  "name": "name",
                  "documentType": "invoice",
                  "partnerId": "partnerId",
                  "currency": "currency",
                  "paymentTermDays": 1000000,
                  "vatScheme": "vatScheme",
                  "vatCountryCode": "vatCountryCode",
                  "agreementId": "agreementId",
                  "operationTypeId": "operationTypeId",
                  "documentSeriesId": "documentSeriesId",
                  "discountPercent": "discountPercent",
                  "issuedByName": "issuedByName",
                  "issuedByTitle": "issuedByTitle",
                  "receivedByName": "receivedByName",
                  "receivedByTitle": "receivedByTitle",
                  "notes": "notes",
                  "supplyType": "goods",
                  "seriesLabel": "seriesLabel",
                  "orderNumber": "orderNumber",
                  "intrastatTransportMode": "intrastatTransportMode",
                  "intrastatDeliveryTerms": "intrastatDeliveryTerms",
                  "intrastatRegion": "intrastatRegion",
                  "intrastatNatureOfTransaction": "intrastatNatureOfTransaction",
                  "lines": [
                    {}
                  ],
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoice-templates/list")
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

        var response = await Client.Sales.InvoiceTemplatesListAsync(
            new InvoiceTemplatesListSalesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
