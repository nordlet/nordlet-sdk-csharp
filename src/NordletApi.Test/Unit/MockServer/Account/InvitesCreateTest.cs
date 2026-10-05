using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvitesCreateTest : BaseMockServerTest
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
              "expiresAt": "2024-01-15T09:30:00.000Z",
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

        var response = await Client.Account.InvitesCreateAsync(
            new InvitesCreateAccountRequest
            {
                Email = "email",
                Role = InvitesCreateAccountRequestRole.Admin,
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
              "expiresAt": "2026-07-01T09:30:00.000Z",
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

        var response = await Client.Account.InvitesCreateAsync(
            new InvitesCreateAccountRequest
            {
                Email = "email",
                Role = InvitesCreateAccountRequestRole.Admin,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
