using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoiceTemplatesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoice-templates/create")
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

        var response = await Client.Sales.InvoiceTemplatesCreateAsync(
            new InvoiceTemplatesCreateSalesRequest
            {
                Name = "x",
                DocumentType = null,
                PartnerId = null,
                Currency = null,
                PaymentTermDays = null,
                VatScheme = null,
                VatCountryCode = null,
                AgreementId = null,
                OperationTypeId = null,
                DocumentSeriesId = null,
                DiscountPercent = null,
                IssuedByName = null,
                IssuedByTitle = null,
                ReceivedByName = null,
                ReceivedByTitle = null,
                Notes = null,
                SupplyType = null,
                SeriesLabel = null,
                OrderNumber = null,
                IntrastatTransportMode = null,
                IntrastatDeliveryTerms = null,
                IntrastatRegion = null,
                IntrastatNatureOfTransaction = null,
                Lines = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "name": "name"
            }
            """;

        const string mockResponse = """
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
                {
                  "itemId": "itemId",
                  "description": "description",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "vatRatePercent": "vatRatePercent",
                  "vatExemptionBasis": "vatExemptionBasis",
                  "projectId": "projectId",
                  "unit": "unit"
                }
              ],
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoice-templates/create")
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

        var response = await Client.Sales.InvoiceTemplatesCreateAsync(
            new InvoiceTemplatesCreateSalesRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
