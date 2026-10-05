using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvitesAcceptTest : BaseMockServerTest
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
              "expiresAt": "2024-01-15T09:30:00.000Z",
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

        var response = await Client.Account.InvitesAcceptAsync(
            new InvitesAcceptAccountRequest
            {
                Token = "strawberry",
                Name = null,
                Locale = null,
                AcceptTerms = null,
                AcceptDpa = null,
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
              "expiresAt": "2026-07-01T09:30:00.000Z",
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

        var response = await Client.Account.InvitesAcceptAsync(
            new InvitesAcceptAccountRequest { Token = "token" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
