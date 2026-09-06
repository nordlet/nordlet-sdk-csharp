using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PullNewTransactionsFromTheBankIntoTheLedgerEmitsBankFeedSyncedTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "connectionId": "x"
            }
            """;

        const string mockResponse = """
            {
              "connectionId": "x",
              "imported": 1000000,
              "skipped": 1000000,
              "posted": 1000000,
              "partnersCreated": 1000000,
              "invoicesCreated": 1000000,
              "invoicesLinked": 1000000,
              "paymentsMatched": 1000000,
              "warnings": [
                "warnings",
                "warnings"
              ],
              "accounts": [
                {
                  "feedAccountId": "x",
                  "imported": 1000000,
                  "fetched": 1000000
                },
                {
                  "feedAccountId": "x",
                  "imported": 1000000,
                  "fetched": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/sync")
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
            await Client.Bank.PullNewTransactionsFromTheBankIntoTheLedgerEmitsBankFeedSyncedAsync(
                new PostV1BankFeedsSyncRequest
                {
                    ConnectionId = "x",
                    FeedAccountId = null,
                    DateFrom = null,
                    DateTo = null,
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "connectionId": "connectionId"
            }
            """;

        const string mockResponse = """
            {
              "connectionId": "connectionId",
              "imported": 1000000,
              "skipped": 1000000,
              "posted": 1000000,
              "partnersCreated": 1000000,
              "invoicesCreated": 1000000,
              "invoicesLinked": 1000000,
              "paymentsMatched": 1000000,
              "warnings": [
                "warnings"
              ],
              "accounts": [
                {
                  "feedAccountId": "feedAccountId",
                  "imported": 1000000,
                  "fetched": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/sync")
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
            await Client.Bank.PullNewTransactionsFromTheBankIntoTheLedgerEmitsBankFeedSyncedAsync(
                new PostV1BankFeedsSyncRequest { ConnectionId = "connectionId" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
