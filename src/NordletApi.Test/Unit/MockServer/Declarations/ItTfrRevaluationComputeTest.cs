using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItTfrRevaluationComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "foiPreviousDecember": "foiPreviousDecember",
              "foiDecember": "foiDecember",
              "funds": [
                {
                  "employeeId": "x",
                  "amount": "amount"
                },
                {
                  "employeeId": "x",
                  "amount": "amount"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "date": "2023-01-15",
              "rate": "rate",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "name": "name",
                  "fund": "fund",
                  "revaluation": "revaluation",
                  "substituteTax": "substituteTax",
                  "fundAfter": "fundAfter"
                },
                {
                  "employeeId": "employeeId",
                  "name": "name",
                  "fund": "fund",
                  "revaluation": "revaluation",
                  "substituteTax": "substituteTax",
                  "fundAfter": "fundAfter"
                }
              ],
              "totals": {
                "revaluation": "revaluation",
                "substituteTax": "substituteTax",
                "accontoNextYear": "accontoNextYear"
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
                    .WithPath("/v1/declarations/it/tfr/revaluation/compute")
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

        var response = await Client.Declarations.ItTfrRevaluationComputeAsync(
            new ItTfrRevaluationComputeDeclarationsRequest
            {
                Year = 1000000,
                FoiPreviousDecember = "foiPreviousDecember",
                FoiDecember = "foiDecember",
                Funds = new List<ItTfrRevaluationComputeDeclarationsRequestFundsItem>()
                {
                    new ItTfrRevaluationComputeDeclarationsRequestFundsItem
                    {
                        EmployeeId = "x",
                        Amount = "amount",
                    },
                    new ItTfrRevaluationComputeDeclarationsRequestFundsItem
                    {
                        EmployeeId = "x",
                        Amount = "amount",
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
              "year": 1000000,
              "foiPreviousDecember": "121.0000",
              "foiDecember": "121.0000",
              "funds": [
                {
                  "employeeId": "employeeId",
                  "amount": "121.00"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "date": "2026-07-01",
              "rate": "rate",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "name": "name",
                  "fund": "fund",
                  "revaluation": "revaluation",
                  "substituteTax": "substituteTax",
                  "fundAfter": "fundAfter"
                }
              ],
              "totals": {
                "revaluation": "revaluation",
                "substituteTax": "substituteTax",
                "accontoNextYear": "accontoNextYear"
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
                    .WithPath("/v1/declarations/it/tfr/revaluation/compute")
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

        var response = await Client.Declarations.ItTfrRevaluationComputeAsync(
            new ItTfrRevaluationComputeDeclarationsRequest
            {
                Year = 1000000,
                FoiPreviousDecember = "121.0000",
                FoiDecember = "121.0000",
                Funds = new List<ItTfrRevaluationComputeDeclarationsRequestFundsItem>()
                {
                    new ItTfrRevaluationComputeDeclarationsRequestFundsItem
                    {
                        EmployeeId = "employeeId",
                        Amount = "121.00",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
