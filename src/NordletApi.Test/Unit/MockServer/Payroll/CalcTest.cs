using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CalcTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "taxableBase": "taxableBase",
              "date": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "taxAllowance": "taxAllowance",
              "incomeTax": "incomeTax",
              "employeeContributions": "employeeContributions",
              "employerContributions": "employerContributions",
              "components": [
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                },
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                }
              ],
              "net": "net"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/calc")
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

        var response = await Client.Payroll.CalcAsync(
            new CalcPayrollRequest
            {
                TaxableBase = "taxableBase",
                Date = new DateOnly(2023, 1, 15),
                ApplyAllowance = null,
                AllowanceOverride = null,
                PensionAccumulation = null,
                FixedTerm = null,
                BenefitInKind = null,
                Options = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "taxableBase": "121.00",
              "date": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "taxAllowance": "taxAllowance",
              "incomeTax": "incomeTax",
              "employeeContributions": "employeeContributions",
              "employerContributions": "employerContributions",
              "components": [
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                }
              ],
              "net": "net"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/calc")
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

        var response = await Client.Payroll.CalcAsync(
            new CalcPayrollRequest { TaxableBase = "121.00", Date = new DateOnly(2026, 7, 1) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
