using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Billing;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AccountGetTest : BaseMockServerTest
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
              "trialEndsAt": "2024-01-15T09:30:00.000Z",
              "firstTopUpAt": "2024-01-15T09:30:00.000Z",
              "lastChargedDate": "2023-01-15",
              "paymentsConfigured": true,
              "hasPaymentAccount": true,
              "hasSubscription": true,
              "paymentFailedAt": "2024-01-15T09:30:00.000Z",
              "paymentFailedInvoiceUrl": "paymentFailedInvoiceUrl",
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

        var response = await Client.Billing.AccountGetAsync(new AccountGetBillingRequest());
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
              "trialEndsAt": "2026-07-01T09:30:00.000Z",
              "firstTopUpAt": "2026-07-01T09:30:00.000Z",
              "lastChargedDate": "2026-07-01",
              "paymentsConfigured": true,
              "hasPaymentAccount": true,
              "hasSubscription": true,
              "paymentFailedAt": "2026-07-01T09:30:00.000Z",
              "paymentFailedInvoiceUrl": "paymentFailedInvoiceUrl",
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

        var response = await Client.Billing.AccountGetAsync(new AccountGetBillingRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
