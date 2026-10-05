using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class JournalTransactionsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "date": "2023-01-15",
              "description": "description",
              "documentType": "documentType",
              "documentId": "x",
              "partnerId": "x",
              "status": "draft",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "postedAt": "2024-01-15T09:30:00.000Z",
              "entries": [
                {
                  "id": "x",
                  "accountId": "x",
                  "accountCode": "accountCode",
                  "accountName": "accountName",
                  "costCenterId": "x",
                  "projectId": "x",
                  "debit": "debit",
                  "credit": "credit",
                  "description": "description"
                },
                {
                  "id": "x",
                  "accountId": "x",
                  "accountCode": "accountCode",
                  "accountName": "accountName",
                  "costCenterId": "x",
                  "projectId": "x",
                  "debit": "debit",
                  "credit": "credit",
                  "description": "description"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/transactions/get")
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

        var response = await Client.Ledger.JournalTransactionsGetAsync(
            new JournalTransactionsGetLedgerRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "date": "2026-07-01",
              "description": "description",
              "documentType": "documentType",
              "documentId": "documentId",
              "partnerId": "partnerId",
              "status": "draft",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "postedAt": "2026-07-01T09:30:00.000Z",
              "entries": [
                {
                  "id": "id",
                  "accountId": "accountId",
                  "accountCode": "accountCode",
                  "accountName": "accountName",
                  "costCenterId": "costCenterId",
                  "projectId": "projectId",
                  "debit": "debit",
                  "credit": "credit",
                  "description": "description"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/transactions/get")
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

        var response = await Client.Ledger.JournalTransactionsGetAsync(
            new JournalTransactionsGetLedgerRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
