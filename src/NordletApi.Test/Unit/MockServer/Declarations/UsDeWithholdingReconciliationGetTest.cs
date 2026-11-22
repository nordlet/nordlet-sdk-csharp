using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsDeWithholdingReconciliationGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "taxpayerId": "taxpayerId",
              "taxPeriodStarting": "taxPeriodStarting",
              "taxPeriodEnding": "taxPeriodEnding",
              "line1": "line1",
              "line2": 1.1,
              "line3": "line3",
              "line4": "line4",
              "line5a": "line5a",
              "line5b": "line5b",
              "line6": "line6",
              "worksheet": [
                {
                  "month": 1.1,
                  "taxPaid": "taxPaid",
                  "taxWithheld": "taxWithheld"
                },
                {
                  "month": 1.1,
                  "taxPaid": "taxPaid",
                  "taxWithheld": "taxWithheld"
                }
              ],
              "totalTaxPaid": "totalTaxPaid",
              "totalTaxWithheld": "totalTaxWithheld",
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/withholding-reconciliation/get")
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

        var response = await Client.Declarations.UsDeWithholdingReconciliationGetAsync(
            new UsDeWithholdingReconciliationGetDeclarationsRequest
            {
                Year = 1000000,
                TaxPaid = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "taxpayerId": "taxpayerId",
              "taxPeriodStarting": "taxPeriodStarting",
              "taxPeriodEnding": "taxPeriodEnding",
              "line1": "line1",
              "line2": 1.1,
              "line3": "line3",
              "line4": "line4",
              "line5a": "line5a",
              "line5b": "line5b",
              "line6": "line6",
              "worksheet": [
                {
                  "month": 1.1,
                  "taxPaid": "taxPaid",
                  "taxWithheld": "taxWithheld"
                }
              ],
              "totalTaxPaid": "totalTaxPaid",
              "totalTaxWithheld": "totalTaxWithheld",
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/withholding-reconciliation/get")
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

        var response = await Client.Declarations.UsDeWithholdingReconciliationGetAsync(
            new UsDeWithholdingReconciliationGetDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
