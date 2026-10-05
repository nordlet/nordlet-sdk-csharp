using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Webhooks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SubscriptionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "url": "url",
              "events": [
                "agreement.invoice_generated",
                "agreement.invoice_generated"
              ]
            }
            """;

        const string mockResponse = """
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
              "createdAt": "2024-01-15T09:30:00.000Z",
              "secret": "secret"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/webhooks/subscriptions/create")
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

        var response = await Client.Webhooks.SubscriptionsCreateAsync(
            new SubscriptionsCreateWebhooksRequest
            {
                Url = "url",
                Events = new List<SubscriptionsCreateWebhooksRequestEventsItem>()
                {
                    SubscriptionsCreateWebhooksRequestEventsItem.AgreementInvoiceGenerated,
                    SubscriptionsCreateWebhooksRequestEventsItem.AgreementInvoiceGenerated,
                },
                Secret = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "url": "url",
              "events": [
                "agreement.invoice_generated"
              ]
            }
            """;

        const string mockResponse = """
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
              "createdAt": "2026-07-01T09:30:00.000Z",
              "secret": "secret"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/webhooks/subscriptions/create")
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

        var response = await Client.Webhooks.SubscriptionsCreateAsync(
            new SubscriptionsCreateWebhooksRequest
            {
                Url = "url",
                Events = new List<SubscriptionsCreateWebhooksRequestEventsItem>()
                {
                    SubscriptionsCreateWebhooksRequestEventsItem.AgreementInvoiceGenerated,
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
