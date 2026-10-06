using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Webhooks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SubscriptionsListTest : BaseMockServerTest
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
                  "url": "url",
                  "events": [
                    "events",
                    "events"
                  ],
                  "isActive": true,
                  "consecutiveFailures": 1000000,
                  "lastDeliveryStatus": "pending",
                  "lastDeliveryAt": "2024-01-15T09:30:00.000Z",
                  "pausedAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "url": "url",
                  "events": [
                    "events",
                    "events"
                  ],
                  "isActive": true,
                  "consecutiveFailures": 1000000,
                  "lastDeliveryStatus": "pending",
                  "lastDeliveryAt": "2024-01-15T09:30:00.000Z",
                  "pausedAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z"
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
                    .WithPath("/v1/webhooks/subscriptions/list")
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

        var response = await Client.Webhooks.SubscriptionsListAsync(
            new SubscriptionsListWebhooksRequest
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
                  "url": "url",
                  "events": [
                    "events"
                  ],
                  "isActive": true,
                  "consecutiveFailures": 1000000,
                  "lastDeliveryStatus": "pending",
                  "lastDeliveryAt": "2026-07-01T09:30:00.000Z",
                  "pausedAt": "2026-07-01T09:30:00.000Z",
                  "createdAt": "2026-07-01T09:30:00.000Z"
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
                    .WithPath("/v1/webhooks/subscriptions/list")
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

        var response = await Client.Webhooks.SubscriptionsListAsync(
            new SubscriptionsListWebhooksRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
