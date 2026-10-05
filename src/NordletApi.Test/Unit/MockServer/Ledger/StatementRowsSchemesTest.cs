using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StatementRowsSchemesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "key": "key",
                  "country": "country",
                  "title": "title",
                  "source": "source",
                  "rows": [
                    {
                      "code": "code",
                      "label": "label",
                      "statement": "balance_sheet"
                    },
                    {
                      "code": "code",
                      "label": "label",
                      "statement": "balance_sheet"
                    }
                  ]
                },
                {
                  "key": "key",
                  "country": "country",
                  "title": "title",
                  "source": "source",
                  "rows": [
                    {
                      "code": "code",
                      "label": "label",
                      "statement": "balance_sheet"
                    },
                    {
                      "code": "code",
                      "label": "label",
                      "statement": "balance_sheet"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/statement-rows/schemes")
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

        var response = await Client.Ledger.StatementRowsSchemesAsync(
            new StatementRowsSchemesLedgerRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "key": "key",
                  "country": "country",
                  "title": "title",
                  "source": "source",
                  "rows": [
                    {
                      "code": "code",
                      "label": "label",
                      "statement": "balance_sheet"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/statement-rows/schemes")
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

        var response = await Client.Ledger.StatementRowsSchemesAsync(
            new StatementRowsSchemesLedgerRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
