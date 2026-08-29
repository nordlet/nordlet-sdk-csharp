using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AccountMeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "user": {
                "id": "x",
                "email": "email",
                "name": "name",
                "locale": "locale",
                "plan": "plan",
                "isSuperAdmin": true
              },
              "locale": "locale",
              "activeCompanyId": "x",
              "role": "role",
              "billing": {
                "status": "trial",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "trialEndsAt"
              },
              "companies": [
                {
                  "id": "x",
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "role": "role",
                  "isSandbox": true,
                  "status": "active",
                  "deletedAt": "deletedAt"
                },
                {
                  "id": "x",
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "role": "role",
                  "isSandbox": true,
                  "status": "active",
                  "deletedAt": "deletedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/me")
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

        var response = await Client.Account.PostV1AccountMeAsync(new PostV1AccountMeRequest());
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
              "user": {
                "id": "id",
                "email": "email",
                "name": "name",
                "locale": "locale",
                "plan": "plan",
                "isSuperAdmin": true
              },
              "locale": "locale",
              "activeCompanyId": "activeCompanyId",
              "role": "role",
              "billing": {
                "status": "trial",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "trialEndsAt"
              },
              "companies": [
                {
                  "id": "id",
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "role": "role",
                  "isSandbox": true,
                  "status": "active",
                  "deletedAt": "deletedAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/me")
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

        var response = await Client.Account.PostV1AccountMeAsync(new PostV1AccountMeRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
