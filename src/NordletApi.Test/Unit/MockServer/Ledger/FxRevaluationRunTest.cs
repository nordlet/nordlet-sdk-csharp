using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FxRevaluationRunTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "date": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "runId": "x",
              "date": "2023-01-15",
              "reversalDate": "2023-01-15",
              "journalTransactionId": "x",
              "reversalJournalTransactionId": "x",
              "gain": "gain",
              "loss": "loss",
              "lines": [
                {
                  "kind": "receivable",
                  "currency": "currency",
                  "partnerId": "x",
                  "accountCode": "accountCode",
                  "amount": "amount"
                },
                {
                  "kind": "receivable",
                  "currency": "currency",
                  "partnerId": "x",
                  "accountCode": "accountCode",
                  "amount": "amount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/fx-revaluation/run")
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

        var response = await Client.Ledger.FxRevaluationRunAsync(
            new FxRevaluationRunLedgerRequest { Date = new DateOnly(2023, 1, 15) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "date": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "runId": "runId",
              "date": "2026-07-01",
              "reversalDate": "2026-07-01",
              "journalTransactionId": "journalTransactionId",
              "reversalJournalTransactionId": "reversalJournalTransactionId",
              "gain": "gain",
              "loss": "loss",
              "lines": [
                {
                  "kind": "receivable",
                  "currency": "currency",
                  "partnerId": "partnerId",
                  "accountCode": "accountCode",
                  "amount": "amount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/fx-revaluation/run")
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

        var response = await Client.Ledger.FxRevaluationRunAsync(
            new FxRevaluationRunLedgerRequest { Date = new DateOnly(2026, 7, 1) }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
