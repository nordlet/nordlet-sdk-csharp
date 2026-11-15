using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Ledger;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FxRevaluationReverseTest : BaseMockServerTest
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
              "undoJournalTransactionIds": [
                "undoJournalTransactionIds",
                "undoJournalTransactionIds"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/fx-revaluation/reverse")
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

        var response = await Client.Ledger.FxRevaluationReverseAsync(
            new FxRevaluationReverseLedgerRequest { Id = "x", Reason = "x" }
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
              "undoJournalTransactionIds": [
                "undoJournalTransactionIds"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/ledger/fx-revaluation/reverse")
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

        var response = await Client.Ledger.FxRevaluationReverseAsync(
            new FxRevaluationReverseLedgerRequest { Id = "id", Reason = "reason" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
