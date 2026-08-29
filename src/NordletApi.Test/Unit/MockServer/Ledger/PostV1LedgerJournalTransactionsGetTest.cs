using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerJournalTransactionsGetTest : BaseMockServerTest
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
              "date": "date",
              "description": "description",
              "documentType": "documentType",
              "documentId": "x",
              "status": "draft",
              "createdAt": "createdAt",
              "postedAt": "postedAt",
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

        var response = await Client.Ledger.PostV1LedgerJournalTransactionsGetAsync(
            new PostV1LedgerJournalTransactionsGetRequest { Id = "x" }
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
              "date": "date",
              "description": "description",
              "documentType": "documentType",
              "documentId": "documentId",
              "status": "draft",
              "createdAt": "createdAt",
              "postedAt": "postedAt",
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

        var response = await Client.Ledger.PostV1LedgerJournalTransactionsGetAsync(
            new PostV1LedgerJournalTransactionsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
