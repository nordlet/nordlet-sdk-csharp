using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TransactionsRecordTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "date": "2023-01-15",
              "amount": "amount",
              "documentType": "sale_invoice",
              "documentId": "x"
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
              "description": "description",
              "externalId": "externalId",
              "status": "new",
              "matchedDocumentType": "matchedDocumentType",
              "matchedDocumentId": "x",
              "journalTransactionId": "x",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/record")
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

        var response = await Client.Bank.TransactionsRecordAsync(
            new TransactionsRecordBankRequest
            {
                BankAccountId = "x",
                Date = new DateOnly(2023, 1, 15),
                Amount = "amount",
                Description = null,
                DocumentType = TransactionsRecordBankRequestDocumentType.SaleInvoice,
                DocumentId = "x",
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
              "date": "2026-07-01",
              "amount": "121.0000",
              "documentType": "sale_invoice",
              "documentId": "documentId"
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
              "description": "description",
              "externalId": "externalId",
              "status": "new",
              "matchedDocumentType": "matchedDocumentType",
              "matchedDocumentId": "matchedDocumentId",
              "journalTransactionId": "journalTransactionId",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/record")
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

        var response = await Client.Bank.TransactionsRecordAsync(
            new TransactionsRecordBankRequest
            {
                BankAccountId = "bankAccountId",
                Date = new DateOnly(2026, 7, 1),
                Amount = "121.0000",
                DocumentType = TransactionsRecordBankRequestDocumentType.SaleInvoice,
                DocumentId = "documentId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
