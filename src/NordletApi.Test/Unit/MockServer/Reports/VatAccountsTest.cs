using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatAccountsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "accounts": [
                {
                  "accountCode": "accountCode",
                  "rules": [
                    "sales.vatPayable",
                    "sales.vatPayable"
                  ],
                  "side": "payable",
                  "posted": "posted",
                  "expected": "expected",
                  "difference": "difference",
                  "settlements": "settlements",
                  "byDocumentType": [
                    {
                      "documentType": "documentType",
                      "debit": "debit",
                      "credit": "credit",
                      "transactions": 1000000
                    },
                    {
                      "documentType": "documentType",
                      "debit": "debit",
                      "credit": "credit",
                      "transactions": 1000000
                    }
                  ]
                },
                {
                  "accountCode": "accountCode",
                  "rules": [
                    "sales.vatPayable",
                    "sales.vatPayable"
                  ],
                  "side": "payable",
                  "posted": "posted",
                  "expected": "expected",
                  "difference": "difference",
                  "settlements": "settlements",
                  "byDocumentType": [
                    {
                      "documentType": "documentType",
                      "debit": "debit",
                      "credit": "credit",
                      "transactions": 1000000
                    },
                    {
                      "documentType": "documentType",
                      "debit": "debit",
                      "credit": "credit",
                      "transactions": 1000000
                    }
                  ]
                }
              ],
              "documents": {
                "outputVat": "outputVat",
                "ossVat": "ossVat",
                "selfAssessedVat": "selfAssessedVat",
                "deductibleVat": "deductibleVat"
              },
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/vat-accounts")
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

        var response = await Client.Reports.VatAccountsAsync(
            new VatAccountsReportsRequest
            {
                Year = 1000000,
                Month = 1000000,
                Months = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "accounts": [
                {
                  "accountCode": "accountCode",
                  "rules": [
                    "sales.vatPayable"
                  ],
                  "side": "payable",
                  "posted": "posted",
                  "expected": "expected",
                  "difference": "difference",
                  "settlements": "settlements",
                  "byDocumentType": [
                    {
                      "documentType": "documentType",
                      "debit": "debit",
                      "credit": "credit",
                      "transactions": 1000000
                    }
                  ]
                }
              ],
              "documents": {
                "outputVat": "outputVat",
                "ossVat": "ossVat",
                "selfAssessedVat": "selfAssessedVat",
                "deductibleVat": "deductibleVat"
              },
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/vat-accounts")
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

        var response = await Client.Reports.VatAccountsAsync(
            new VatAccountsReportsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
