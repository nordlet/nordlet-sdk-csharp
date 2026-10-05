using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AnnualAccountsDistributionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "decidedOn": "2023-01-15",
              "kind": "dividend",
              "amount": "amount"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "decidedOn": "decidedOn",
              "kind": "dividend",
              "amount": "amount",
              "description": "description"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/distributions/create")
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

        var response = await Client.Declarations.AnnualAccountsDistributionsCreateAsync(
            new AnnualAccountsDistributionsCreateDeclarationsRequest
            {
                Year = 1000000,
                DecidedOn = new DateOnly(2023, 1, 15),
                Kind = AnnualAccountsDistributionsCreateDeclarationsRequestKind.Dividend,
                Amount = "amount",
                Description = null,
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
              "decidedOn": "2026-07-01",
              "kind": "dividend",
              "amount": "121.00"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "decidedOn": "decidedOn",
              "kind": "dividend",
              "amount": "amount",
              "description": "description"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/annual-accounts/distributions/create")
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

        var response = await Client.Declarations.AnnualAccountsDistributionsCreateAsync(
            new AnnualAccountsDistributionsCreateDeclarationsRequest
            {
                Year = 1000000,
                DecidedOn = new DateOnly(2026, 7, 1),
                Kind = AnnualAccountsDistributionsCreateDeclarationsRequestKind.Dividend,
                Amount = "121.00",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
