using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TransactionsImportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "transactions": [
                {
                  "date": "2023-01-15",
                  "amount": "amount"
                },
                {
                  "date": "2023-01-15",
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

        var response = await Client.Bank.TransactionsImportAsync(
            new TransactionsImportBankRequest
            {
                BankAccountId = "x",
                Transactions = new List<TransactionsImportBankRequestTransactionsItem>()
                {
                    new TransactionsImportBankRequestTransactionsItem
                    {
                        Date = new DateOnly(2023, 1, 15),
                        Amount = "amount",
                        Currency = null,
                        CounterpartyName = null,
                        CounterpartyIban = null,
                        Description = null,
                        ExternalId = null,
                    },
                    new TransactionsImportBankRequestTransactionsItem
                    {
                        Date = new DateOnly(2023, 1, 15),
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
                  "date": "2026-07-01",
                  "amount": "-121.0000"
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

        var response = await Client.Bank.TransactionsImportAsync(
            new TransactionsImportBankRequest
            {
                BankAccountId = "bankAccountId",
                Transactions = new List<TransactionsImportBankRequestTransactionsItem>()
                {
                    new TransactionsImportBankRequestTransactionsItem
                    {
                        Date = new DateOnly(2026, 7, 1),
                        Amount = "-121.0000",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
