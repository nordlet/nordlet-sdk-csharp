using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LedgerJournalTransactionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "date": "date",
              "entries": [
                {
                  "accountCode": "x"
                },
                {
                  "accountCode": "x"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "date": "date",
              "description": "description",
              "documentType": "documentType",
              "documentId": "x",
              "partnerId": "x",
              "status": "draft",
              "createdAt": "createdAt",
              "postedAt": "postedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/transactions/create")
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

        var response = await Client.Ledger.PostV1LedgerJournalTransactionsCreateAsync(
            new PostV1LedgerJournalTransactionsCreateRequest
            {
                Date = "date",
                Description = null,
                Entries = new List<PostV1LedgerJournalTransactionsCreateRequestEntriesItem>()
                {
                    new PostV1LedgerJournalTransactionsCreateRequestEntriesItem
                    {
                        AccountCode = "x",
                        CostCenterId = null,
                        ProjectId = null,
                        Debit = null,
                        Credit = null,
                        Description = null,
                    },
                    new PostV1LedgerJournalTransactionsCreateRequestEntriesItem
                    {
                        AccountCode = "x",
                        CostCenterId = null,
                        ProjectId = null,
                        Debit = null,
                        Credit = null,
                        Description = null,
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
              "date": "date",
              "entries": [
                {
                  "accountCode": "accountCode"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "date": "date",
              "description": "description",
              "documentType": "documentType",
              "documentId": "documentId",
              "partnerId": "partnerId",
              "status": "draft",
              "createdAt": "createdAt",
              "postedAt": "postedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/transactions/create")
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

        var response = await Client.Ledger.PostV1LedgerJournalTransactionsCreateAsync(
            new PostV1LedgerJournalTransactionsCreateRequest
            {
                Date = "date",
                Entries = new List<PostV1LedgerJournalTransactionsCreateRequestEntriesItem>()
                {
                    new PostV1LedgerJournalTransactionsCreateRequestEntriesItem
                    {
                        AccountCode = "accountCode",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
