using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FeedsConnectionsListTest : BaseMockServerTest
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
                  "consentExpiresAt": "2024-01-15T09:30:00.000Z",
                  "lastSyncedAt": "2024-01-15T09:30:00.000Z",
                  "error": "error",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "provider": "provider",
                  "aspspName": "aspspName",
                  "aspspCountry": "aspspCountry",
                  "psuType": "business",
                  "status": "pending",
                  "reference": "reference",
                  "consentExpiresAt": "2024-01-15T09:30:00.000Z",
                  "lastSyncedAt": "2024-01-15T09:30:00.000Z",
                  "error": "error",
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

        var response = await Client.Bank.FeedsConnectionsListAsync(
            new FeedsConnectionsListBankRequest
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
                  "consentExpiresAt": "2026-07-01T09:30:00.000Z",
                  "lastSyncedAt": "2026-07-01T09:30:00.000Z",
                  "error": "error",
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

        var response = await Client.Bank.FeedsConnectionsListAsync(
            new FeedsConnectionsListBankRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
