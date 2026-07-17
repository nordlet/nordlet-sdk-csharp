using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Webhooks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1WebhooksSubscriptionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "url": "url",
              "events": [
                "events",
                "events"
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
              "createdAt": "createdAt",
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

        var response = await Client.Webhooks.PostV1WebhooksSubscriptionsCreateAsync(
            new PostV1WebhooksSubscriptionsCreateRequest
            {
                Url = "url",
                Events = new List<string>() { "events", "events" },
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
                "events"
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
              "createdAt": "createdAt",
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

        var response = await Client.Webhooks.PostV1WebhooksSubscriptionsCreateAsync(
            new PostV1WebhooksSubscriptionsCreateRequest
            {
                Url = "url",
                Events = new List<string>() { "events" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
