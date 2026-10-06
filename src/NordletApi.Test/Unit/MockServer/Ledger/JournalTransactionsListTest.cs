using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class JournalTransactionsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                  "partnerName": "partnerName"
                },
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
                  "partnerName": "partnerName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/transactions/list")
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

        var response = await Client.Ledger.JournalTransactionsListAsync(
            new JournalTransactionsListLedgerRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                  "partnerName": "partnerName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/journal/transactions/list")
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

        var response = await Client.Ledger.JournalTransactionsListAsync(
            new JournalTransactionsListLedgerRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
