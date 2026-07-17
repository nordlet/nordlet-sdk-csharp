using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankStatementsImportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "bankAccountId": "x",
              "content": "x"
            }
            """;

        const string mockResponse = """
            {
              "imported": 1000000,
              "skipped": 1000000,
              "statements": [
                {
                  "statementId": "statementId",
                  "iban": "iban",
                  "fromDate": "fromDate",
                  "toDate": "toDate",
                  "openingBalance": "openingBalance",
                  "closingBalance": "closingBalance",
                  "transactionCount": 1000000
                },
                {
                  "statementId": "statementId",
                  "iban": "iban",
                  "fromDate": "fromDate",
                  "toDate": "toDate",
                  "openingBalance": "openingBalance",
                  "closingBalance": "closingBalance",
                  "transactionCount": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/statements/import")
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

        var response = await Client.Bank.PostV1BankStatementsImportAsync(
            new PostV1BankStatementsImportRequest
            {
                BankAccountId = "x",
                Format = null,
                Content = "x",
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
              "content": "content"
            }
            """;

        const string mockResponse = """
            {
              "imported": 1000000,
              "skipped": 1000000,
              "statements": [
                {
                  "statementId": "statementId",
                  "iban": "iban",
                  "fromDate": "fromDate",
                  "toDate": "toDate",
                  "openingBalance": "openingBalance",
                  "closingBalance": "closingBalance",
                  "transactionCount": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/statements/import")
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

        var response = await Client.Bank.PostV1BankStatementsImportAsync(
            new PostV1BankStatementsImportRequest
            {
                BankAccountId = "bankAccountId",
                Content = "content",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
