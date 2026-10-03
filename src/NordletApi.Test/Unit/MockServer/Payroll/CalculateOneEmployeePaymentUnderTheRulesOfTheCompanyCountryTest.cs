using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CalculateOneEmployeePaymentUnderTheRulesOfTheCompanyCountryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "taxableBase": "taxableBase",
              "date": "date"
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

        var response =
            await Client.Payroll.CalculateOneEmployeePaymentUnderTheRulesOfTheCompanyCountryAsync(
                new PostV1PayrollCalcRequest
                {
                    TaxableBase = "taxableBase",
                    Date = "date",
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
              "taxableBase": "taxableBase",
              "date": "date"
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

        var response =
            await Client.Payroll.CalculateOneEmployeePaymentUnderTheRulesOfTheCompanyCountryAsync(
                new PostV1PayrollCalcRequest { TaxableBase = "taxableBase", Date = "date" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
