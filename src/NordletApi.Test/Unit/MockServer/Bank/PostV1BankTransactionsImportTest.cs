using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankTransactionsImportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "transactions": [
                {
                  "date": "date",
                  "amount": "amount"
                },
                {
                  "date": "date",
                  "amount": "amount"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "imported": 1000000,
              "skipped": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/import")
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

        var response = await Client.Bank.PostV1BankTransactionsImportAsync(
            new PostV1BankTransactionsImportRequest
            {
                BankAccountId = "x",
                Transactions = new List<PostV1BankTransactionsImportRequestTransactionsItem>()
                {
                    new PostV1BankTransactionsImportRequestTransactionsItem
                    {
                        Date = "date",
                        Amount = "amount",
                        Currency = null,
                        CounterpartyName = null,
                        CounterpartyIban = null,
                        Description = null,
                        ExternalId = null,
                    },
                    new PostV1BankTransactionsImportRequestTransactionsItem
                    {
                        Date = "date",
                        Amount = "amount",
                        Currency = null,
                        CounterpartyName = null,
                        CounterpartyIban = null,
                        Description = null,
                        ExternalId = null,
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
              "bankAccountId": "bankAccountId",
              "transactions": [
                {
                  "date": "date",
                  "amount": "amount"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "imported": 1000000,
              "skipped": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/import")
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

        var response = await Client.Bank.PostV1BankTransactionsImportAsync(
            new PostV1BankTransactionsImportRequest
            {
                BankAccountId = "bankAccountId",
                Transactions = new List<PostV1BankTransactionsImportRequestTransactionsItem>()
                {
                    new PostV1BankTransactionsImportRequestTransactionsItem
                    {
                        Date = "date",
                        Amount = "amount",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
