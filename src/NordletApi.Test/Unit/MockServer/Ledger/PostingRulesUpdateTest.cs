using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostingRulesUpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "rules": [
                {
                  "key": "sales.receivable"
                },
                {
                  "key": "sales.receivable"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "key": "key",
                  "description": "description",
                  "defaultCode": "defaultCode",
                  "accountCode": "accountCode",
                  "overridden": true
                },
                {
                  "key": "key",
                  "description": "description",
                  "defaultCode": "defaultCode",
                  "accountCode": "accountCode",
                  "overridden": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/posting-rules/update")
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

        var response = await Client.Ledger.PostingRulesUpdateAsync(
            new PostingRulesUpdateLedgerRequest
            {
                Rules = new List<PostingRulesUpdateLedgerRequestRulesItem>()
                {
                    new PostingRulesUpdateLedgerRequestRulesItem
                    {
                        Key = PostingRulesUpdateLedgerRequestRulesItemKey.SalesReceivable,
                        AccountCode = null,
                    },
                    new PostingRulesUpdateLedgerRequestRulesItem
                    {
                        Key = PostingRulesUpdateLedgerRequestRulesItemKey.SalesReceivable,
                        AccountCode = null,
                    },
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
              "rules": [
                {
                  "key": "sales.receivable"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "key": "key",
                  "description": "description",
                  "defaultCode": "defaultCode",
                  "accountCode": "accountCode",
                  "overridden": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/posting-rules/update")
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

        var response = await Client.Ledger.PostingRulesUpdateAsync(
            new PostingRulesUpdateLedgerRequest
            {
                Rules = new List<PostingRulesUpdateLedgerRequestRulesItem>()
                {
                    new PostingRulesUpdateLedgerRequestRulesItem
                    {
                        Key = PostingRulesUpdateLedgerRequestRulesItemKey.SalesReceivable,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
