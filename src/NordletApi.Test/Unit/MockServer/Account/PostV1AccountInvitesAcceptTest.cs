using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountInvitesAcceptTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "token": "strawberry"
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "expiresAt": "expiresAt",
              "user": {
                "id": "x",
                "email": "email",
                "name": "name",
                "plan": "plan"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/invites/accept")
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

        var response = await Client.Account.PostV1AccountInvitesAcceptAsync(
            new PostV1AccountInvitesAcceptRequest
            {
                Token = "strawberry",
                Name = null,
                Locale = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "token": "token"
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "expiresAt": "expiresAt",
              "user": {
                "id": "id",
                "email": "email",
                "name": "name",
                "plan": "plan"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/invites/accept")
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

        var response = await Client.Account.PostV1AccountInvitesAcceptAsync(
            new PostV1AccountInvitesAcceptRequest { Token = "token" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
