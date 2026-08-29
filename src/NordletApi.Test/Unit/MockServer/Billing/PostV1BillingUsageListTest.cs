using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Billing;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BillingUsageListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "from": "from",
              "to": "to"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "companyId": "x",
                  "date": "date",
                  "metric": "api_request",
                  "quantity": 1.1
                },
                {
                  "companyId": "x",
                  "date": "date",
                  "metric": "api_request",
                  "quantity": 1.1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/billing/usage/list")
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

        var response = await Client.Billing.PostV1BillingUsageListAsync(
            new PostV1BillingUsageListRequest { From = "from", To = "to" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "from": "from",
              "to": "to"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "companyId": "companyId",
                  "date": "date",
                  "metric": "api_request",
                  "quantity": 1.1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/billing/usage/list")
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

        var response = await Client.Billing.PostV1BillingUsageListAsync(
            new PostV1BillingUsageListRequest { From = "from", To = "to" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
