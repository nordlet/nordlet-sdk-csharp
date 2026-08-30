using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountConsentAcceptTest : BaseMockServerTest
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
              "termsAcceptedAt": "termsAcceptedAt",
              "dpaVersion": "dpaVersion",
              "dpaAcceptedAt": "dpaAcceptedAt",
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

        var response = await Client.Account.PostV1AccountConsentAcceptAsync(
            new PostV1AccountConsentAcceptRequest { AcceptTerms = true, AcceptDpa = true }
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
              "termsAcceptedAt": "termsAcceptedAt",
              "dpaVersion": "dpaVersion",
              "dpaAcceptedAt": "dpaAcceptedAt",
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

        var response = await Client.Account.PostV1AccountConsentAcceptAsync(
            new PostV1AccountConsentAcceptRequest { AcceptTerms = true, AcceptDpa = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
