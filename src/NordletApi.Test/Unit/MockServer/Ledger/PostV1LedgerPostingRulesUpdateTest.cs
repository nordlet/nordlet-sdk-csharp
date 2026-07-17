using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerPostingRulesUpdateTest : BaseMockServerTest
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

        var response = await Client.Ledger.PostV1LedgerPostingRulesUpdateAsync(
            new PostV1LedgerPostingRulesUpdateRequest
            {
                Rules = new List<PostV1LedgerPostingRulesUpdateRequestRulesItem>()
                {
                    new PostV1LedgerPostingRulesUpdateRequestRulesItem
                    {
                        Key = PostV1LedgerPostingRulesUpdateRequestRulesItemKey.SalesReceivable,
                        AccountCode = null,
                    },
                    new PostV1LedgerPostingRulesUpdateRequestRulesItem
                    {
                        Key = PostV1LedgerPostingRulesUpdateRequestRulesItemKey.SalesReceivable,
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

        var response = await Client.Ledger.PostV1LedgerPostingRulesUpdateAsync(
            new PostV1LedgerPostingRulesUpdateRequest
            {
                Rules = new List<PostV1LedgerPostingRulesUpdateRequestRulesItem>()
                {
                    new PostV1LedgerPostingRulesUpdateRequestRulesItem
                    {
                        Key = PostV1LedgerPostingRulesUpdateRequestRulesItemKey.SalesReceivable,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
