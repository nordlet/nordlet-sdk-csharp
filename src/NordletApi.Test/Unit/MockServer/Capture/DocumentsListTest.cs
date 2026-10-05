using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Capture;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DocumentsListTest : BaseMockServerTest
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
                  "fileId": "x",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "status": "pending",
                  "provider": "provider",
                  "model": "model",
                  "pagesProcessed": 1000000,
                  "extraction": {
                    "supplier": {
                      "name": "name",
                      "code": "code",
                      "vatCode": "vatCode",
                      "countryCode": "countryCode",
                      "iban": "iban"
                    },
                    "documentNumber": "documentNumber",
                    "documentDate": "2023-01-15",
                    "dueDate": "2023-01-15",
                    "currency": "currency",
                    "netTotal": "netTotal",
                    "vatTotal": "vatTotal",
                    "grossTotal": "grossTotal",
                    "notes": "notes",
                    "lines": [
                      {
                        "description": "description",
                        "quantity": "quantity",
                        "unit": "unit",
                        "unitPriceExclVat": "unitPriceExclVat",
                        "vatRatePercent": "vatRatePercent",
                        "lineNet": "lineNet",
                        "lineVat": "lineVat",
                        "lineGross": "lineGross"
                      },
                      {
                        "description": "description",
                        "quantity": "quantity",
                        "unit": "unit",
                        "unitPriceExclVat": "unitPriceExclVat",
                        "vatRatePercent": "vatRatePercent",
                        "lineNet": "lineNet",
                        "lineVat": "lineVat",
                        "lineGross": "lineGross"
                      }
                    ]
                  },
                  "matchedPartnerId": "x",
                  "purchaseInvoiceId": "x",
                  "error": "error",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "fileId": "x",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "status": "pending",
                  "provider": "provider",
                  "model": "model",
                  "pagesProcessed": 1000000,
                  "extraction": {
                    "supplier": {
                      "name": "name",
                      "code": "code",
                      "vatCode": "vatCode",
                      "countryCode": "countryCode",
                      "iban": "iban"
                    },
                    "documentNumber": "documentNumber",
                    "documentDate": "2023-01-15",
                    "dueDate": "2023-01-15",
                    "currency": "currency",
                    "netTotal": "netTotal",
                    "vatTotal": "vatTotal",
                    "grossTotal": "grossTotal",
                    "notes": "notes",
                    "lines": [
                      {
                        "description": "description",
                        "quantity": "quantity",
                        "unit": "unit",
                        "unitPriceExclVat": "unitPriceExclVat",
                        "vatRatePercent": "vatRatePercent",
                        "lineNet": "lineNet",
                        "lineVat": "lineVat",
                        "lineGross": "lineGross"
                      },
                      {
                        "description": "description",
                        "quantity": "quantity",
                        "unit": "unit",
                        "unitPriceExclVat": "unitPriceExclVat",
                        "vatRatePercent": "vatRatePercent",
                        "lineNet": "lineNet",
                        "lineVat": "lineVat",
                        "lineGross": "lineGross"
                      }
                    ]
                  },
                  "matchedPartnerId": "x",
                  "purchaseInvoiceId": "x",
                  "error": "error",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                    .WithPath("/v1/capture/documents/list")
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

        var response = await Client.Capture.DocumentsListAsync(
            new DocumentsListCaptureRequest
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
                  "fileId": "fileId",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "status": "pending",
                  "provider": "provider",
                  "model": "model",
                  "pagesProcessed": 1000000,
                  "extraction": {
                    "supplier": {},
                    "documentDate": "2026-07-01",
                    "dueDate": "2026-07-01",
                    "lines": [
                      {
                        "description": "description",
                        "quantity": "quantity"
                      }
                    ]
                  },
                  "matchedPartnerId": "matchedPartnerId",
                  "purchaseInvoiceId": "purchaseInvoiceId",
                  "error": "error",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
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
                    .WithPath("/v1/capture/documents/list")
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

        var response = await Client.Capture.DocumentsListAsync(new DocumentsListCaptureRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
