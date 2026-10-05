using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class JournalTransactionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "date": "2023-01-15",
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
              "date": "2023-01-15",
              "description": "description",
              "documentType": "documentType",
              "documentId": "x",
              "partnerId": "x",
              "status": "draft",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "postedAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Ledger.JournalTransactionsCreateAsync(
            new JournalTransactionsCreateLedgerRequest
            {
                Date = new DateOnly(2023, 1, 15),
                Description = null,
                Entries = new List<JournalTransactionsCreateLedgerRequestEntriesItem>()
                {
                    new JournalTransactionsCreateLedgerRequestEntriesItem
                    {
                        AccountCode = "x",
                        CostCenterId = null,
                        ProjectId = null,
                        Debit = null,
                        Credit = null,
                        Description = null,
                    },
                    new JournalTransactionsCreateLedgerRequestEntriesItem
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
              "date": "2026-07-01",
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
              "date": "2026-07-01",
              "description": "description",
              "documentType": "documentType",
              "documentId": "documentId",
              "partnerId": "partnerId",
              "status": "draft",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "postedAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Ledger.JournalTransactionsCreateAsync(
            new JournalTransactionsCreateLedgerRequest
            {
                Date = new DateOnly(2026, 7, 1),
                Entries = new List<JournalTransactionsCreateLedgerRequestEntriesItem>()
                {
                    new JournalTransactionsCreateLedgerRequestEntriesItem
                    {
                        AccountCode = "accountCode",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
