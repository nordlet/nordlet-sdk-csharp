using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReferralGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "code": "code",
              "link": "link",
              "points": 1000000,
              "referredCount": 1000000,
              "rates": {
                "perEur": 1000000,
                "pointCents": 1000000
              },
              "history": [
                {
                  "points": 1000000,
                  "reason": "reason",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "points": 1000000,
                  "reason": "reason",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/referral/get")
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

        var response = await Client.Account.ReferralGetAsync(new ReferralGetAccountRequest());
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
              "code": "code",
              "link": "link",
              "points": 1000000,
              "referredCount": 1000000,
              "rates": {
                "perEur": 1000000,
                "pointCents": 1000000
              },
              "history": [
                {
                  "points": 1000000,
                  "reason": "reason",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/referral/get")
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

        var response = await Client.Account.ReferralGetAsync(new ReferralGetAccountRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
