using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountInvitesListTest : BaseMockServerTest
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
                  "email": "email",
                  "role": "role",
                  "expiresAt": "expiresAt",
                  "createdAt": "createdAt",
                  "expired": true
                },
                {
                  "id": "x",
                  "email": "email",
                  "role": "role",
                  "expiresAt": "expiresAt",
                  "createdAt": "createdAt",
                  "expired": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/invites/list")
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

        var response = await Client.Account.PostV1AccountInvitesListAsync(
            new PostV1AccountInvitesListRequest()
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
                  "email": "email",
                  "role": "role",
                  "expiresAt": "expiresAt",
                  "createdAt": "createdAt",
                  "expired": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/invites/list")
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

        var response = await Client.Account.PostV1AccountInvitesListAsync(
            new PostV1AccountInvitesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
