using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TransactionsIgnoreTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "transactionId": "x",
              "reason": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "bankAccountId": "x",
              "date": "2023-01-15",
              "amount": "amount",
              "currency": "currency",
              "counterpartyName": "counterpartyName",
              "counterpartyIban": "counterpartyIban",
              "partnerId": "x",
              "partnerName": "partnerName",
              "description": "description",
              "externalId": "externalId",
              "status": "new",
              "matchedDocumentType": "matchedDocumentType",
              "matchedDocumentId": "x",
              "journalTransactionId": "x",
              "ignoreReason": "ignoreReason",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/ignore")
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

        var response = await Client.Bank.TransactionsIgnoreAsync(
            new TransactionsIgnoreBankRequest { TransactionId = "x", Reason = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "transactionId": "transactionId",
              "reason": "reason"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "bankAccountId": "bankAccountId",
              "date": "2026-07-01",
              "amount": "amount",
              "currency": "currency",
              "counterpartyName": "counterpartyName",
              "counterpartyIban": "counterpartyIban",
              "partnerId": "partnerId",
              "partnerName": "partnerName",
              "description": "description",
              "externalId": "externalId",
              "status": "new",
              "matchedDocumentType": "matchedDocumentType",
              "matchedDocumentId": "matchedDocumentId",
              "journalTransactionId": "journalTransactionId",
              "ignoreReason": "ignoreReason",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/ignore")
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

        var response = await Client.Bank.TransactionsIgnoreAsync(
            new TransactionsIgnoreBankRequest { TransactionId = "transactionId", Reason = "reason" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
