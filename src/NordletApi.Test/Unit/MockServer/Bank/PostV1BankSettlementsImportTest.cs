using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankSettlementsImportTest : BaseMockServerTest
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
              "format": "payout_reconciliation",
              "imported": 1000000,
              "updated": 1000000,
              "skipped": 1000000,
              "skippedUnassigned": 1000000,
              "skippedPayoutRows": 1000000,
              "skippedNotSettled": 1000000,
              "batches": [
                {
                  "id": "x",
                  "bankAccountId": "x",
                  "provider": "provider",
                  "payoutId": "payoutId",
                  "payoutDate": "payoutDate",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "feeTotal": "feeTotal",
                  "netTotal": "netTotal",
                  "status": "imported",
                  "journalTransactionId": "x",
                  "lineCount": 1000000,
                  "matchedCount": 1000000,
                  "unmatchedCount": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "bankAccountId": "x",
                  "provider": "provider",
                  "payoutId": "payoutId",
                  "payoutDate": "payoutDate",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "feeTotal": "feeTotal",
                  "netTotal": "netTotal",
                  "status": "imported",
                  "journalTransactionId": "x",
                  "lineCount": 1000000,
                  "matchedCount": 1000000,
                  "unmatchedCount": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/import")
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

        var response = await Client.Bank.PostV1BankSettlementsImportAsync(
            new PostV1BankSettlementsImportRequest
            {
                BankAccountId = "x",
                Provider = null,
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
              "format": "payout_reconciliation",
              "imported": 1000000,
              "updated": 1000000,
              "skipped": 1000000,
              "skippedUnassigned": 1000000,
              "skippedPayoutRows": 1000000,
              "skippedNotSettled": 1000000,
              "batches": [
                {
                  "id": "id",
                  "bankAccountId": "bankAccountId",
                  "provider": "provider",
                  "payoutId": "payoutId",
                  "payoutDate": "payoutDate",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "feeTotal": "feeTotal",
                  "netTotal": "netTotal",
                  "status": "imported",
                  "journalTransactionId": "journalTransactionId",
                  "lineCount": 1000000,
                  "matchedCount": 1000000,
                  "unmatchedCount": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/import")
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

        var response = await Client.Bank.PostV1BankSettlementsImportAsync(
            new PostV1BankSettlementsImportRequest
            {
                BankAccountId = "bankAccountId",
                Content = "content",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
