using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Billing;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BillingTransactionsListTest : BaseMockServerTest
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
                  "type": "trial_grant",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "reference": "reference",
                  "usageDate": "usageDate",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "type": "trial_grant",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "reference": "reference",
                  "usageDate": "usageDate",
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/billing/transactions/list")
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

        var response = await Client.Billing.PostV1BillingTransactionsListAsync(
            new PostV1BillingTransactionsListRequest { Limit = null }
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
                  "type": "trial_grant",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "reference": "reference",
                  "usageDate": "usageDate",
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/billing/transactions/list")
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

        var response = await Client.Billing.PostV1BillingTransactionsListAsync(
            new PostV1BillingTransactionsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
