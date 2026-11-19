using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsDeFranchiseTaxComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "authorizedShares": [
                {
                  "shares": 1000000
                },
                {
                  "shares": 1000000
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "authorizedShares": 1.1,
              "authorizedSharesMethodTax": "authorizedSharesMethodTax",
              "assumedPar": "assumedPar",
              "assumedParValueCapital": "assumedParValueCapital",
              "assumedNoParCapital": "assumedNoParCapital",
              "assumedParValueCapitalMethodTax": "assumedParValueCapitalMethodTax",
              "method": "authorized-shares",
              "tax": "tax",
              "annualReportFee": "annualReportFee"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/franchise-tax/compute")
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

        var response = await Client.Declarations.UsDeFranchiseTaxComputeAsync(
            new UsDeFranchiseTaxComputeDeclarationsRequest
            {
                AuthorizedShares =
                    new List<UsDeFranchiseTaxComputeDeclarationsRequestAuthorizedSharesItem>()
                    {
                        new UsDeFranchiseTaxComputeDeclarationsRequestAuthorizedSharesItem
                        {
                            Shares = 1000000,
                            ParValue = null,
                        },
                        new UsDeFranchiseTaxComputeDeclarationsRequestAuthorizedSharesItem
                        {
                            Shares = 1000000,
                            ParValue = null,
                        },
                    },
                IssuedShares = null,
                TotalGrossAssets = null,
                LargeCorporateFiler = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "authorizedShares": [
                {
                  "shares": 1000000
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "authorizedShares": 1.1,
              "authorizedSharesMethodTax": "authorizedSharesMethodTax",
              "assumedPar": "assumedPar",
              "assumedParValueCapital": "assumedParValueCapital",
              "assumedNoParCapital": "assumedNoParCapital",
              "assumedParValueCapitalMethodTax": "assumedParValueCapitalMethodTax",
              "method": "authorized-shares",
              "tax": "tax",
              "annualReportFee": "annualReportFee"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/franchise-tax/compute")
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

        var response = await Client.Declarations.UsDeFranchiseTaxComputeAsync(
            new UsDeFranchiseTaxComputeDeclarationsRequest
            {
                AuthorizedShares =
                    new List<UsDeFranchiseTaxComputeDeclarationsRequestAuthorizedSharesItem>()
                    {
                        new UsDeFranchiseTaxComputeDeclarationsRequestAuthorizedSharesItem
                        {
                            Shares = 1000000,
                        },
                    },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
