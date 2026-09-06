using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankTransactionsRecordTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "date": "date",
              "amount": "amount",
              "documentType": "sale_invoice",
              "documentId": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "bankAccountId": "x",
              "date": "date",
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
              "createdAt": "createdAt"
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

        var response = await Client.Bank.PostV1BankTransactionsRecordAsync(
            new PostV1BankTransactionsRecordRequest
            {
                BankAccountId = "x",
                Date = "date",
                Amount = "amount",
                Description = null,
                DocumentType = PostV1BankTransactionsRecordRequestDocumentType.SaleInvoice,
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
              "date": "date",
              "amount": "amount",
              "documentType": "sale_invoice",
              "documentId": "documentId"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "bankAccountId": "bankAccountId",
              "date": "date",
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
              "createdAt": "createdAt"
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

        var response = await Client.Bank.PostV1BankTransactionsRecordAsync(
            new PostV1BankTransactionsRecordRequest
            {
                BankAccountId = "bankAccountId",
                Date = "date",
                Amount = "amount",
                DocumentType = PostV1BankTransactionsRecordRequestDocumentType.SaleInvoice,
                DocumentId = "documentId",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
