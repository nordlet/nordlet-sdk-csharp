using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ConsentAcceptTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "acceptTerms": true,
              "acceptDpa": true
            }
            """;

        const string mockResponse = """
            {
              "termsVersion": "termsVersion",
              "termsAcceptedAt": "2024-01-15T09:30:00.000Z",
              "dpaVersion": "dpaVersion",
              "dpaAcceptedAt": "2024-01-15T09:30:00.000Z",
              "currentTermsVersion": "currentTermsVersion",
              "currentDpaVersion": "currentDpaVersion",
              "required": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/consent/accept")
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

        var response = await Client.Account.ConsentAcceptAsync(
            new ConsentAcceptAccountRequest { AcceptTerms = true, AcceptDpa = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "acceptTerms": true,
              "acceptDpa": true
            }
            """;

        const string mockResponse = """
            {
              "termsVersion": "termsVersion",
              "termsAcceptedAt": "2026-07-01T09:30:00.000Z",
              "dpaVersion": "dpaVersion",
              "dpaAcceptedAt": "2026-07-01T09:30:00.000Z",
              "currentTermsVersion": "currentTermsVersion",
              "currentDpaVersion": "currentDpaVersion",
              "required": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/consent/accept")
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

        var response = await Client.Account.ConsentAcceptAsync(
            new ConsentAcceptAccountRequest { AcceptTerms = true, AcceptDpa = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
