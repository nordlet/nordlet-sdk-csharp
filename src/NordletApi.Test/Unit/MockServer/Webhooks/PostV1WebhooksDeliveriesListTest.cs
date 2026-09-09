using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Webhooks;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1WebhooksDeliveriesListTest : BaseMockServerTest
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
                  "subscriptionId": "x",
                  "eventType": "eventType",
                  "status": "pending",
                  "attempts": 1000000,
                  "lastError": "lastError",
                  "createdAt": "createdAt",
                  "deliveredAt": "deliveredAt"
                },
                {
                  "id": "x",
                  "subscriptionId": "x",
                  "eventType": "eventType",
                  "status": "pending",
                  "attempts": 1000000,
                  "lastError": "lastError",
                  "createdAt": "createdAt",
                  "deliveredAt": "deliveredAt"
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
                    .WithPath("/v1/webhooks/deliveries/list")
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

        var response = await Client.Webhooks.PostV1WebhooksDeliveriesListAsync(
            new PostV1WebhooksDeliveriesListRequest
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
                  "subscriptionId": "subscriptionId",
                  "eventType": "eventType",
                  "status": "pending",
                  "attempts": 1000000,
                  "lastError": "lastError",
                  "createdAt": "createdAt",
                  "deliveredAt": "deliveredAt"
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
                    .WithPath("/v1/webhooks/deliveries/list")
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

        var response = await Client.Webhooks.PostV1WebhooksDeliveriesListAsync(
            new PostV1WebhooksDeliveriesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
