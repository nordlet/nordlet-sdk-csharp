using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReconciliationGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "date": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "bankAccountId": "x",
              "accountCode": "accountCode",
              "currency": "currency",
              "date": "2023-01-15",
              "statementBalance": "statementBalance",
              "statementBalanceSource": "request",
              "statementClosingDate": "2023-01-15",
              "ledgerBalance": "ledgerBalance",
              "difference": "difference",
              "unbookedCount": 1000000,
              "unbookedTotal": "unbookedTotal",
              "unbookedLines": [
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
                  "ignoreReason": "ignoreReason",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
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
                  "ignoreReason": "ignoreReason",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/reconciliation/get")
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

        var response = await Client.Bank.ReconciliationGetAsync(
            new ReconciliationGetBankRequest
            {
                BankAccountId = "x",
                Date = new DateOnly(2023, 1, 15),
                StatementBalance = null,
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
              "date": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "bankAccountId": "bankAccountId",
              "accountCode": "accountCode",
              "currency": "currency",
              "date": "2026-07-01",
              "statementBalance": "statementBalance",
              "statementBalanceSource": "request",
              "statementClosingDate": "2026-07-01",
              "ledgerBalance": "ledgerBalance",
              "difference": "difference",
              "unbookedCount": 1000000,
              "unbookedTotal": "unbookedTotal",
              "unbookedLines": [
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
                  "ignoreReason": "ignoreReason",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/reconciliation/get")
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

        var response = await Client.Bank.ReconciliationGetAsync(
            new ReconciliationGetBankRequest
            {
                BankAccountId = "bankAccountId",
                Date = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
