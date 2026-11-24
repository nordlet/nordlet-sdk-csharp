using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItTfrAccrualComputeTest : BaseMockServerTest
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
              "year": 1000000,
              "month": 1000000,
              "date": "2023-01-15",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "name": "name",
                  "destination": "azienda",
                  "base": "base",
                  "quota": "quota",
                  "contributionBase": "contributionBase",
                  "contribution": "contribution",
                  "accrual": "accrual",
                  "leftOut": [
                    {
                      "paymentType": "paymentType",
                      "amount": "amount"
                    },
                    {
                      "paymentType": "paymentType",
                      "amount": "amount"
                    }
                  ]
                },
                {
                  "employeeId": "employeeId",
                  "name": "name",
                  "destination": "azienda",
                  "base": "base",
                  "quota": "quota",
                  "contributionBase": "contributionBase",
                  "contribution": "contribution",
                  "accrual": "accrual",
                  "leftOut": [
                    {
                      "paymentType": "paymentType",
                      "amount": "amount"
                    },
                    {
                      "paymentType": "paymentType",
                      "amount": "amount"
                    }
                  ]
                }
              ],
              "totals": {
                "kept": "kept",
                "paidOut": "paidOut",
                "accrual": "accrual"
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
                    .WithPath("/v1/declarations/it/tfr/accrual/compute")
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

        var response = await Client.Declarations.ItTfrAccrualComputeAsync(
            new ItTfrAccrualComputeDeclarationsRequest
            {
                Year = 1000000,
                Month = 1000000,
                IncludePaymentTypes = null,
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
              "year": 1000000,
              "month": 1000000,
              "date": "2026-07-01",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "name": "name",
                  "destination": "azienda",
                  "base": "base",
                  "quota": "quota",
                  "contributionBase": "contributionBase",
                  "contribution": "contribution",
                  "accrual": "accrual",
                  "leftOut": [
                    {
                      "paymentType": "paymentType",
                      "amount": "amount"
                    }
                  ]
                }
              ],
              "totals": {
                "kept": "kept",
                "paidOut": "paidOut",
                "accrual": "accrual"
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
                    .WithPath("/v1/declarations/it/tfr/accrual/compute")
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

        var response = await Client.Declarations.ItTfrAccrualComputeAsync(
            new ItTfrAccrualComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
