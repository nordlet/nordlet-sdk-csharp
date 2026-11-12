using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class JournalTransactionsReverseTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "reason": "x"
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
                    .WithPath("/v1/ledger/journal/transactions/reverse")
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

        var response = await Client.Ledger.JournalTransactionsReverseAsync(
            new JournalTransactionsReverseLedgerRequest
            {
                Id = "x",
                Reason = "x",
                Date = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "reason": "reason"
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
                    .WithPath("/v1/ledger/journal/transactions/reverse")
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

        var response = await Client.Ledger.JournalTransactionsReverseAsync(
            new JournalTransactionsReverseLedgerRequest { Id = "id", Reason = "reason" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
