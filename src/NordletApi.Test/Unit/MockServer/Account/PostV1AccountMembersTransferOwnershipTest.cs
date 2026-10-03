using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountMembersTransferOwnershipTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "userId": "x"
            }
            """;

        const string mockResponse = """
            {
              "ownerUserId": "x",
              "previousOwnerRole": "previousOwnerRole",
              "payerUserId": "x"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/members/transfer-ownership")
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

        var response = await Client.Account.PostV1AccountMembersTransferOwnershipAsync(
            new PostV1AccountMembersTransferOwnershipRequest { UserId = "x", MovePayer = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "userId": "userId"
            }
            """;

        const string mockResponse = """
            {
              "ownerUserId": "ownerUserId",
              "previousOwnerRole": "previousOwnerRole",
              "payerUserId": "payerUserId"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/members/transfer-ownership")
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

        var response = await Client.Account.PostV1AccountMembersTransferOwnershipAsync(
            new PostV1AccountMembersTransferOwnershipRequest { UserId = "userId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
