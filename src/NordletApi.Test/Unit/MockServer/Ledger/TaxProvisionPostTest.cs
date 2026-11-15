using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TaxProvisionPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fiscalYear": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "date": "2023-01-15",
              "fiscalYear": 1000000,
              "amount": "amount"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/tax-provision/post")
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

        var response = await Client.Ledger.TaxProvisionPostAsync(
            new TaxProvisionPostLedgerRequest { FiscalYear = 1000000, Amount = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fiscalYear": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "date": "2026-07-01",
              "fiscalYear": 1000000,
              "amount": "amount"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/tax-provision/post")
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

        var response = await Client.Ledger.TaxProvisionPostAsync(
            new TaxProvisionPostLedgerRequest { FiscalYear = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
