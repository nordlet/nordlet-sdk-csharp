using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountMembersSetRoleTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "userId": "x",
              "role": "admin"
            }
            """;

        const string mockResponse = """
            {
              "userId": "x",
              "role": "role"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/members/set-role")
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

        var response = await Client.Account.PostV1AccountMembersSetRoleAsync(
            new PostV1AccountMembersSetRoleRequest
            {
                UserId = "x",
                Role = PostV1AccountMembersSetRoleRequestRole.Admin,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "userId": "userId",
              "role": "admin"
            }
            """;

        const string mockResponse = """
            {
              "userId": "userId",
              "role": "role"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/members/set-role")
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

        var response = await Client.Account.PostV1AccountMembersSetRoleAsync(
            new PostV1AccountMembersSetRoleRequest
            {
                UserId = "userId",
                Role = PostV1AccountMembersSetRoleRequestRole.Admin,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
