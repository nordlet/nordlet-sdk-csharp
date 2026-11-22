using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbReturnFactsSetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "facts": {}
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "facts": {
                "companyType": 1000000,
                "associatedCompanies": 1000000,
                "partnerInFirm": true,
                "smallCompaniesRegime": true,
                "auditExemptionSection477": true,
                "depreciation": "depreciation",
                "amortisation": "amortisation",
                "lossOrProfitOnSale": "lossOrProfitOnSale",
                "entertaining": "entertaining",
                "otherAdditions": "otherAdditions",
                "nonTradingLoanCredits": "nonTradingLoanCredits",
                "nonTradingLoanDebits": "nonTradingLoanDebits",
                "nonTaxableIncome": "nonTaxableIncome",
                "exemptDistributions": "exemptDistributions",
                "capitalAllowances": {
                  "fullExpensing": "fullExpensing",
                  "annualInvestmentAllowance": "annualInvestmentAllowance",
                  "specialRatePool": "specialRatePool",
                  "mainPool": "mainPool",
                  "structuresAndBuildings": "structuresAndBuildings",
                  "other": "other"
                },
                "balancingCharges": {
                  "fullExpensing": "fullExpensing",
                  "specialRatePool": "specialRatePool",
                  "mainPool": "mainPool",
                  "other": "other"
                },
                "tradingLossesBroughtForward": "tradingLossesBroughtForward",
                "grossChargeableGains": "grossChargeableGains",
                "allowableLosses": "allowableLosses",
                "qualifyingDonations": "qualifyingDonations",
                "taxAlreadyPaid": "taxAlreadyPaid",
                "declarantName": "xy",
                "declarantStatus": "xy",
                "seniorStatutoryAuditor": "xy"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/return-facts/set")
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

        var response = await Client.Declarations.GbReturnFactsSetAsync(
            new GbReturnFactsSetDeclarationsRequest
            {
                Year = 1000000,
                Facts = new GbReturnFactsSetDeclarationsRequestFacts
                {
                    CompanyType = null,
                    AssociatedCompanies = null,
                    PartnerInFirm = null,
                    SmallCompaniesRegime = null,
                    AuditExemptionSection477 = null,
                    Depreciation = null,
                    Amortisation = null,
                    LossOrProfitOnSale = null,
                    Entertaining = null,
                    OtherAdditions = null,
                    NonTradingLoanCredits = null,
                    NonTradingLoanDebits = null,
                    NonTaxableIncome = null,
                    ExemptDistributions = null,
                    CapitalAllowances = null,
                    BalancingCharges = null,
                    TradingLossesBroughtForward = null,
                    GrossChargeableGains = null,
                    AllowableLosses = null,
                    QualifyingDonations = null,
                    TaxAlreadyPaid = null,
                    DeclarantName = null,
                    DeclarantStatus = null,
                    SeniorStatutoryAuditor = null,
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
              "facts": {}
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "facts": {
                "companyType": 1000000,
                "associatedCompanies": 1000000,
                "partnerInFirm": true,
                "smallCompaniesRegime": true,
                "auditExemptionSection477": true,
                "depreciation": "121.00",
                "amortisation": "121.00",
                "lossOrProfitOnSale": "-121.00",
                "entertaining": "121.00",
                "otherAdditions": "121.00",
                "nonTradingLoanCredits": "121.00",
                "nonTradingLoanDebits": "121.00",
                "nonTaxableIncome": "121.00",
                "exemptDistributions": "121.00",
                "capitalAllowances": {
                  "fullExpensing": "121.00",
                  "annualInvestmentAllowance": "121.00",
                  "specialRatePool": "121.00",
                  "mainPool": "121.00",
                  "structuresAndBuildings": "121.00",
                  "other": "121.00"
                },
                "balancingCharges": {
                  "fullExpensing": "121.00",
                  "specialRatePool": "121.00",
                  "mainPool": "121.00",
                  "other": "121.00"
                },
                "tradingLossesBroughtForward": "121.00",
                "grossChargeableGains": "121.00",
                "allowableLosses": "121.00",
                "qualifyingDonations": "121.00",
                "taxAlreadyPaid": "121.00",
                "declarantName": "declarantName",
                "declarantStatus": "declarantStatus",
                "seniorStatutoryAuditor": "seniorStatutoryAuditor"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/return-facts/set")
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

        var response = await Client.Declarations.GbReturnFactsSetAsync(
            new GbReturnFactsSetDeclarationsRequest
            {
                Year = 1000000,
                Facts = new GbReturnFactsSetDeclarationsRequestFacts(),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
