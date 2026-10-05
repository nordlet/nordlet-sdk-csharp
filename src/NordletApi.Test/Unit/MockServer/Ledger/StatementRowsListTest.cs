using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class StatementRowsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "scheme": "x"
            }
            """;

        const string mockResponse = """
            {
              "scheme": {
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
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "accounts": [
                {
                  "code": "code",
                  "name": "name",
                  "type": "type",
                  "rowCode": "rowCode",
                  "source": "mapping",
                  "amount": "amount"
                },
                {
                  "code": "code",
                  "name": "name",
                  "type": "type",
                  "rowCode": "rowCode",
                  "source": "mapping",
                  "amount": "amount"
                }
              ],
              "rows": [
                {
                  "code": "code",
                  "label": "label",
                  "statement": "balance_sheet",
                  "amount": "amount"
                },
                {
                  "code": "code",
                  "label": "label",
                  "statement": "balance_sheet",
                  "amount": "amount"
                }
              ],
              "unmapped": [
                "unmapped",
                "unmapped"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/statement-rows/list")
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

        var response = await Client.Ledger.StatementRowsListAsync(
            new StatementRowsListLedgerRequest
            {
                Scheme = "x",
                FromDate = null,
                ToDate = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "scheme": "scheme"
            }
            """;

        const string mockResponse = """
            {
              "scheme": {
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
              },
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "accounts": [
                {
                  "code": "code",
                  "name": "name",
                  "type": "type",
                  "rowCode": "rowCode",
                  "source": "mapping",
                  "amount": "amount"
                }
              ],
              "rows": [
                {
                  "code": "code",
                  "label": "label",
                  "statement": "balance_sheet",
                  "amount": "amount"
                }
              ],
              "unmapped": [
                "unmapped"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/statement-rows/list")
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

        var response = await Client.Ledger.StatementRowsListAsync(
            new StatementRowsListLedgerRequest { Scheme = "scheme" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
