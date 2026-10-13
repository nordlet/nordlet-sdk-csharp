using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SecuritiesImportTest : BaseMockServerTest
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
              "id": "x",
              "bankAccountId": "x",
              "broker": "broker",
              "brokerAccount": "brokerAccount",
              "period": "period",
              "fileName": "fileName",
              "operationCount": 1000000,
              "duplicateCount": 1000000,
              "postedCount": 1000000,
              "notPostedCount": 1000000,
              "realizedTotal": "realizedTotal",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/securities/import")
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

        var response = await Client.Bank.SecuritiesImportAsync(
            new SecuritiesImportBankRequest
            {
                BankAccountId = "x",
                Content = "x",
                FileName = null,
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
              "id": "id",
              "bankAccountId": "bankAccountId",
              "broker": "broker",
              "brokerAccount": "brokerAccount",
              "period": "period",
              "fileName": "fileName",
              "operationCount": 1000000,
              "duplicateCount": 1000000,
              "postedCount": 1000000,
              "notPostedCount": 1000000,
              "realizedTotal": "realizedTotal",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/securities/import")
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

        var response = await Client.Bank.SecuritiesImportAsync(
            new SecuritiesImportBankRequest { BankAccountId = "bankAccountId", Content = "content" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
