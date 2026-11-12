using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TransactionsPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "transactionId": "x",
              "accountCode": "x"
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
                    .WithPath("/v1/bank/transactions/post")
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

        var response = await Client.Bank.TransactionsPostAsync(
            new TransactionsPostBankRequest
            {
                TransactionId = "x",
                AccountCode = "x",
                TaxPaymentId = null,
                PartnerId = null,
                CostCenterId = null,
                ProjectId = null,
                Description = null,
                VatClassifierCode = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "transactionId": "transactionId",
              "accountCode": "accountCode"
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
                    .WithPath("/v1/bank/transactions/post")
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

        var response = await Client.Bank.TransactionsPostAsync(
            new TransactionsPostBankRequest
            {
                TransactionId = "transactionId",
                AccountCode = "accountCode",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
