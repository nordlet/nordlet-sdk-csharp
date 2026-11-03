using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OauthAuthorizeDenyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "clientId": "x"
            }
            """;

        const string mockResponse = """
            {
              "redirectTo": "redirectTo"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/oauth/authorize/deny")
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

        var response = await Client.Account.OauthAuthorizeDenyAsync(
            new OauthAuthorizeDenyAccountRequest
            {
                ClientId = "x",
                RedirectUri = null,
                ResponseType = null,
                CodeChallenge = null,
                CodeChallengeMethod = null,
                State = null,
                Scope = null,
                Resource = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "clientId": "clientId"
            }
            """;

        const string mockResponse = """
            {
              "redirectTo": "redirectTo"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/oauth/authorize/deny")
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

        var response = await Client.Account.OauthAuthorizeDenyAsync(
            new OauthAuthorizeDenyAccountRequest { ClientId = "clientId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
