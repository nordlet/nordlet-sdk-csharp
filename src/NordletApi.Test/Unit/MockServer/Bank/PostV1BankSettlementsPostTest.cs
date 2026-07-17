using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankSettlementsPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
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
              "updatedAt": "updatedAt",
              "warnings": [
                "warnings",
                "warnings"
              ],
              "summary": {
                "receivableApplied": "receivableApplied",
                "commissionAmount": "commissionAmount",
                "sellerAmount": "sellerAmount",
                "feeAmount": "feeAmount",
                "suspenseAmount": "suspenseAmount"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/post")
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

        var response = await Client.Bank.PostV1BankSettlementsPostAsync(
            new PostV1BankSettlementsPostRequest
            {
                Id = "x",
                Date = null,
                CommissionPercent = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
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
              "updatedAt": "updatedAt",
              "warnings": [
                "warnings"
              ],
              "summary": {
                "receivableApplied": "receivableApplied",
                "commissionAmount": "commissionAmount",
                "sellerAmount": "sellerAmount",
                "feeAmount": "feeAmount",
                "suspenseAmount": "suspenseAmount"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/settlements/post")
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

        var response = await Client.Bank.PostV1BankSettlementsPostAsync(
            new PostV1BankSettlementsPostRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
