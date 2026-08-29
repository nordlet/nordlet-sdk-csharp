using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Billing;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BillingAccountGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "plan": "starter",
              "status": "trial",
              "balanceCents": 1000000,
              "trialEndsAt": "trialEndsAt",
              "firstTopUpAt": "firstTopUpAt",
              "lastChargedDate": "lastChargedDate",
              "paymentsConfigured": true,
              "monthToDate": {
                "from": "from",
                "to": "to",
                "apiRequests": 1000000,
                "ocrPages": 1000000,
                "fileBytes": 1.1,
                "databaseBytes": 1.1,
                "archivedCompanies": 1000000,
                "estimatedTodayCents": 1000000
              },
              "plans": {
                "plans": {
                  "monthlyFeeEur": "monthlyFeeEur",
                  "includedRequests": 1000000,
                  "requestOverageEur": "requestOverageEur",
                  "includedDatabaseBytes": 1.1,
                  "includedFileBytes": 1.1
                }
              },
              "topUp": {
                "minCents": 1000000,
                "maxCents": 1000000
              },
              "trialDays": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/billing/account/get")
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

        var response = await Client.Billing.PostV1BillingAccountGetAsync(
            new PostV1BillingAccountGetRequest()
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
              "plan": "starter",
              "status": "trial",
              "balanceCents": 1000000,
              "trialEndsAt": "trialEndsAt",
              "firstTopUpAt": "firstTopUpAt",
              "lastChargedDate": "lastChargedDate",
              "paymentsConfigured": true,
              "monthToDate": {
                "from": "from",
                "to": "to",
                "apiRequests": 1000000,
                "ocrPages": 1000000,
                "fileBytes": 1.1,
                "databaseBytes": 1.1,
                "archivedCompanies": 1000000,
                "estimatedTodayCents": 1000000
              },
              "plans": {
                "key": {
                  "monthlyFeeEur": "monthlyFeeEur",
                  "includedRequests": 1000000,
                  "requestOverageEur": "requestOverageEur",
                  "includedDatabaseBytes": 1.1,
                  "includedFileBytes": 1.1
                }
              },
              "topUp": {
                "minCents": 1000000,
                "maxCents": 1000000
              },
              "trialDays": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/billing/account/get")
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

        var response = await Client.Billing.PostV1BillingAccountGetAsync(
            new PostV1BillingAccountGetRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
