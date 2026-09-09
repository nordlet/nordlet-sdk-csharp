using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankFeedsConnectionsListTest : BaseMockServerTest
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
                  "provider": "provider",
                  "aspspName": "aspspName",
                  "aspspCountry": "aspspCountry",
                  "psuType": "business",
                  "status": "pending",
                  "reference": "reference",
                  "consentExpiresAt": "consentExpiresAt",
                  "lastSyncedAt": "lastSyncedAt",
                  "error": "error",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "provider": "provider",
                  "aspspName": "aspspName",
                  "aspspCountry": "aspspCountry",
                  "psuType": "business",
                  "status": "pending",
                  "reference": "reference",
                  "consentExpiresAt": "consentExpiresAt",
                  "lastSyncedAt": "lastSyncedAt",
                  "error": "error",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/connections/list")
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

        var response = await Client.Bank.PostV1BankFeedsConnectionsListAsync(
            new PostV1BankFeedsConnectionsListRequest
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
                  "provider": "provider",
                  "aspspName": "aspspName",
                  "aspspCountry": "aspspCountry",
                  "psuType": "business",
                  "status": "pending",
                  "reference": "reference",
                  "consentExpiresAt": "consentExpiresAt",
                  "lastSyncedAt": "lastSyncedAt",
                  "error": "error",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/feeds/connections/list")
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

        var response = await Client.Bank.PostV1BankFeedsConnectionsListAsync(
            new PostV1BankFeedsConnectionsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
