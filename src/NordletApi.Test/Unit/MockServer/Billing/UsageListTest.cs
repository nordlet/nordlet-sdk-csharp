using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Billing;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsageListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "from": "2023-01-15",
              "to": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "companyId": "x",
                  "date": "2023-01-15",
                  "metric": "api_request",
                  "quantity": 1.1
                },
                {
                  "companyId": "x",
                  "date": "2023-01-15",
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

        var response = await Client.Billing.UsageListAsync(
            new UsageListBillingRequest
            {
                From = new DateOnly(2023, 1, 15),
                To = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "from": "2026-07-01",
              "to": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "companyId": "companyId",
                  "date": "2026-07-01",
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

        var response = await Client.Billing.UsageListAsync(
            new UsageListBillingRequest
            {
                From = new DateOnly(2026, 7, 1),
                To = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
