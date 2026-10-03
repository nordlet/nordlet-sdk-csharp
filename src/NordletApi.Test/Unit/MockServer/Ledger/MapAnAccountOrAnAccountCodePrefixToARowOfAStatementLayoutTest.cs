using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MapAnAccountOrAnAccountCodePrefixToARowOfAStatementLayoutTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "scheme": "x",
              "accountCode": "x"
            }
            """;

        const string mockResponse = """
            {
              "scheme": "scheme",
              "accountCode": "accountCode",
              "rowCode": "rowCode"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/statement-rows/set")
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
            await Client.Ledger.MapAnAccountOrAnAccountCodePrefixToARowOfAStatementLayoutAsync(
                new PostV1LedgerStatementRowsSetRequest
                {
                    Scheme = "x",
                    AccountCode = "x",
                    RowCode = null,
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "scheme": "scheme",
              "accountCode": "accountCode"
            }
            """;

        const string mockResponse = """
            {
              "scheme": "scheme",
              "accountCode": "accountCode",
              "rowCode": "rowCode"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/statement-rows/set")
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
            await Client.Ledger.MapAnAccountOrAnAccountCodePrefixToARowOfAStatementLayoutAsync(
                new PostV1LedgerStatementRowsSetRequest
                {
                    Scheme = "scheme",
                    AccountCode = "accountCode",
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
