using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SettlementsListTest : BaseMockServerTest
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
                  "bankAccountId": "x",
                  "provider": "provider",
                  "payoutId": "payoutId",
                  "payoutDate": "2023-01-15",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "feeTotal": "feeTotal",
                  "netTotal": "netTotal",
                  "fxRate": "fxRate",
                  "status": "imported",
                  "journalTransactionId": "x",
                  "bankTransactionId": "x",
                  "lineCount": 1000000,
                  "matchedCount": 1000000,
                  "unmatchedCount": 1000000,
                  "clearedNet": "clearedNet",
                  "clearingDifference": "clearingDifference",
                  "clearingOpenCount": 1000000,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "bankAccountId": "x",
                  "provider": "provider",
                  "payoutId": "payoutId",
                  "payoutDate": "2023-01-15",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "feeTotal": "feeTotal",
                  "netTotal": "netTotal",
                  "fxRate": "fxRate",
                  "status": "imported",
                  "journalTransactionId": "x",
                  "bankTransactionId": "x",
                  "lineCount": 1000000,
                  "matchedCount": 1000000,
                  "unmatchedCount": 1000000,
                  "clearedNet": "clearedNet",
                  "clearingDifference": "clearingDifference",
                  "clearingOpenCount": 1000000,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                    .WithPath("/v1/bank/settlements/list")
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

        var response = await Client.Bank.SettlementsListAsync(
            new SettlementsListBankRequest
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
                  "bankAccountId": "bankAccountId",
                  "provider": "provider",
                  "payoutId": "payoutId",
                  "payoutDate": "2026-07-01",
                  "currency": "currency",
                  "grossTotal": "grossTotal",
                  "feeTotal": "feeTotal",
                  "netTotal": "netTotal",
                  "fxRate": "fxRate",
                  "status": "imported",
                  "journalTransactionId": "journalTransactionId",
                  "bankTransactionId": "bankTransactionId",
                  "lineCount": 1000000,
                  "matchedCount": 1000000,
                  "unmatchedCount": 1000000,
                  "clearedNet": "clearedNet",
                  "clearingDifference": "clearingDifference",
                  "clearingOpenCount": 1000000,
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
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
                    .WithPath("/v1/bank/settlements/list")
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

        var response = await Client.Bank.SettlementsListAsync(new SettlementsListBankRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
