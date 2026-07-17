using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountInvitesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "email": "email",
              "role": "admin"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "email": "email",
              "role": "role",
              "expiresAt": "expiresAt",
              "inviteUrl": "inviteUrl",
              "emailSent": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/invites/create")
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

        var response = await Client.Account.PostV1AccountInvitesCreateAsync(
            new PostV1AccountInvitesCreateRequest
            {
                Email = "email",
                Role = PostV1AccountInvitesCreateRequestRole.Admin,
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
              "email": "email",
              "role": "admin"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "email": "email",
              "role": "role",
              "expiresAt": "expiresAt",
              "inviteUrl": "inviteUrl",
              "emailSent": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/invites/create")
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

        var response = await Client.Account.PostV1AccountInvitesCreateAsync(
            new PostV1AccountInvitesCreateRequest
            {
                Email = "email",
                Role = PostV1AccountInvitesCreateRequestRole.Admin,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
