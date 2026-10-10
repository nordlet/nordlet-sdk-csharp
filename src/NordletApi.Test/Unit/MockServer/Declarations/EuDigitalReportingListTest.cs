using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EuDigitalReportingListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "appliesFrom": "appliesFrom",
              "reportTo": "reportTo",
              "transactions": [
                {
                  "direction": "supply",
                  "article": "262(1)(a)",
                  "documentId": "documentId",
                  "documentType": "invoice",
                  "number": "number",
                  "issueDate": "2023-01-15",
                  "partnerName": "partnerName",
                  "supplierVatNumber": "supplierVatNumber",
                  "customerVatNumber": "customerVatNumber",
                  "currency": "currency",
                  "lines": [
                    {
                      "description": "description",
                      "quantity": "quantity",
                      "unit": "unit",
                      "unitPrice": "unitPrice",
                      "taxableAmount": "taxableAmount",
                      "vatRatePercent": "vatRatePercent",
                      "vatAmount": "vatAmount"
                    },
                    {
                      "description": "description",
                      "quantity": "quantity",
                      "unit": "unit",
                      "unitPrice": "unitPrice",
                      "taxableAmount": "taxableAmount",
                      "vatRatePercent": "vatRatePercent",
                      "vatAmount": "vatAmount"
                    }
                  ],
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "exemptionReference": "exemptionReference",
                  "reverseCharge": true,
                  "correctedInvoiceNumber": "correctedInvoiceNumber",
                  "supplierAccounts": [
                    "supplierAccounts",
                    "supplierAccounts"
                  ],
                  "reportTo": "reportTo",
                  "deadline": "deadline",
                  "missing": [
                    "missing",
                    "missing"
                  ]
                },
                {
                  "direction": "supply",
                  "article": "262(1)(a)",
                  "documentId": "documentId",
                  "documentType": "invoice",
                  "number": "number",
                  "issueDate": "2023-01-15",
                  "partnerName": "partnerName",
                  "supplierVatNumber": "supplierVatNumber",
                  "customerVatNumber": "customerVatNumber",
                  "currency": "currency",
                  "lines": [
                    {
                      "description": "description",
                      "quantity": "quantity",
                      "unit": "unit",
                      "unitPrice": "unitPrice",
                      "taxableAmount": "taxableAmount",
                      "vatRatePercent": "vatRatePercent",
                      "vatAmount": "vatAmount"
                    },
                    {
                      "description": "description",
                      "quantity": "quantity",
                      "unit": "unit",
                      "unitPrice": "unitPrice",
                      "taxableAmount": "taxableAmount",
                      "vatRatePercent": "vatRatePercent",
                      "vatAmount": "vatAmount"
                    }
                  ],
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "exemptionReference": "exemptionReference",
                  "reverseCharge": true,
                  "correctedInvoiceNumber": "correctedInvoiceNumber",
                  "supplierAccounts": [
                    "supplierAccounts",
                    "supplierAccounts"
                  ],
                  "reportTo": "reportTo",
                  "deadline": "deadline",
                  "missing": [
                    "missing",
                    "missing"
                  ]
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/digital-reporting/list")
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

        var response = await Client.Declarations.EuDigitalReportingListAsync(
            new EuDigitalReportingListDeclarationsRequest
            {
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "appliesFrom": "appliesFrom",
              "reportTo": "reportTo",
              "transactions": [
                {
                  "direction": "supply",
                  "article": "262(1)(a)",
                  "documentId": "documentId",
                  "documentType": "invoice",
                  "number": "number",
                  "issueDate": "2026-07-01",
                  "partnerName": "partnerName",
                  "supplierVatNumber": "supplierVatNumber",
                  "customerVatNumber": "customerVatNumber",
                  "currency": "currency",
                  "lines": [
                    {
                      "description": "description",
                      "quantity": "quantity",
                      "unit": "unit",
                      "taxableAmount": "taxableAmount",
                      "vatRatePercent": "vatRatePercent",
                      "vatAmount": "vatAmount"
                    }
                  ],
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "exemptionReference": "exemptionReference",
                  "reverseCharge": true,
                  "correctedInvoiceNumber": "correctedInvoiceNumber",
                  "supplierAccounts": [
                    "supplierAccounts"
                  ],
                  "reportTo": "reportTo",
                  "deadline": "deadline",
                  "missing": [
                    "missing"
                  ]
                }
              ],
              "warnings": [
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/digital-reporting/list")
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

        var response = await Client.Declarations.EuDigitalReportingListAsync(
            new EuDigitalReportingListDeclarationsRequest
            {
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
