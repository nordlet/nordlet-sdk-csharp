using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbCorporationTaxComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "periodStart": "2023-01-15",
              "periodEnd": "2023-01-15",
              "taxableTotalProfits": "taxableTotalProfits"
            }
            """;

        const string mockResponse = """
            {
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "days": 1.1,
              "taxableTotalProfits": "taxableTotalProfits",
              "augmentedProfits": "augmentedProfits",
              "parts": [
                {
                  "financialYear": 1.1,
                  "from": "from",
                  "to": "to",
                  "days": 1.1,
                  "profits": "profits",
                  "augmentedProfits": "augmentedProfits",
                  "lowerLimit": "lowerLimit",
                  "upperLimit": "upperLimit",
                  "rate": "main",
                  "taxAtMainRate": "taxAtMainRate",
                  "marginalRelief": "marginalRelief",
                  "tax": "tax"
                },
                {
                  "financialYear": 1.1,
                  "from": "from",
                  "to": "to",
                  "days": 1.1,
                  "profits": "profits",
                  "augmentedProfits": "augmentedProfits",
                  "lowerLimit": "lowerLimit",
                  "upperLimit": "upperLimit",
                  "rate": "main",
                  "taxAtMainRate": "taxAtMainRate",
                  "marginalRelief": "marginalRelief",
                  "tax": "tax"
                }
              ],
              "marginalRelief": "marginalRelief",
              "tax": "tax",
              "notes": [
                "notes",
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/corporation-tax/compute")
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

        var response = await Client.Declarations.GbCorporationTaxComputeAsync(
            new GbCorporationTaxComputeDeclarationsRequest
            {
                PeriodStart = new DateOnly(2023, 1, 15),
                PeriodEnd = new DateOnly(2023, 1, 15),
                TaxableTotalProfits = "taxableTotalProfits",
                ExemptDistributions = null,
                AssociatedCompanies = null,
                CloseInvestmentHolding = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "periodStart": "2026-07-01",
              "periodEnd": "2026-07-01",
              "taxableTotalProfits": "taxableTotalProfits"
            }
            """;

        const string mockResponse = """
            {
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "days": 1.1,
              "taxableTotalProfits": "taxableTotalProfits",
              "augmentedProfits": "augmentedProfits",
              "parts": [
                {
                  "financialYear": 1.1,
                  "from": "from",
                  "to": "to",
                  "days": 1.1,
                  "profits": "profits",
                  "augmentedProfits": "augmentedProfits",
                  "lowerLimit": "lowerLimit",
                  "upperLimit": "upperLimit",
                  "rate": "main",
                  "taxAtMainRate": "taxAtMainRate",
                  "marginalRelief": "marginalRelief",
                  "tax": "tax"
                }
              ],
              "marginalRelief": "marginalRelief",
              "tax": "tax",
              "notes": [
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/corporation-tax/compute")
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

        var response = await Client.Declarations.GbCorporationTaxComputeAsync(
            new GbCorporationTaxComputeDeclarationsRequest
            {
                PeriodStart = new DateOnly(2026, 7, 1),
                PeriodEnd = new DateOnly(2026, 7, 1),
                TaxableTotalProfits = "taxableTotalProfits",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
