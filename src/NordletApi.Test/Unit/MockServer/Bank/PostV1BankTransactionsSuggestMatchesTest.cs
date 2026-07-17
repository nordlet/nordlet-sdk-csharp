using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankTransactionsSuggestMatchesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "transactionId": "x"
            }
            """;

        const string mockResponse = """
            {
              "suggestions": [
                {
                  "documentType": "sale_invoice",
                  "documentId": "x",
                  "number": "number",
                  "partnerName": "partnerName",
                  "grossTotal": "grossTotal",
                  "remaining": "remaining",
                  "score": 1000000,
                  "reasons": [
                    "reasons",
                    "reasons"
                  ]
                },
                {
                  "documentType": "sale_invoice",
                  "documentId": "x",
                  "number": "number",
                  "partnerName": "partnerName",
                  "grossTotal": "grossTotal",
                  "remaining": "remaining",
                  "score": 1000000,
                  "reasons": [
                    "reasons",
                    "reasons"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/suggest-matches")
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

        var response = await Client.Bank.PostV1BankTransactionsSuggestMatchesAsync(
            new PostV1BankTransactionsSuggestMatchesRequest { TransactionId = "x", Limit = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "transactionId": "transactionId"
            }
            """;

        const string mockResponse = """
            {
              "suggestions": [
                {
                  "documentType": "sale_invoice",
                  "documentId": "documentId",
                  "number": "number",
                  "partnerName": "partnerName",
                  "grossTotal": "grossTotal",
                  "remaining": "remaining",
                  "score": 1000000,
                  "reasons": [
                    "reasons"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/transactions/suggest-matches")
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

        var response = await Client.Bank.PostV1BankTransactionsSuggestMatchesAsync(
            new PostV1BankTransactionsSuggestMatchesRequest { TransactionId = "transactionId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
