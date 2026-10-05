using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MeTest : BaseMockServerTest
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
              "timeZone": "timeZone",
              "role": "role",
              "billing": {
                "status": "trial",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "2024-01-15T09:30:00.000Z",
                "payerUserId": "x",
                "payerEmail": "payerEmail",
                "isPayer": true
              },
              "referralPoints": 1000000,
              "consent": {
                "termsVersion": "termsVersion",
                "termsAcceptedAt": "2024-01-15T09:30:00.000Z",
                "dpaVersion": "dpaVersion",
                "dpaAcceptedAt": "2024-01-15T09:30:00.000Z",
                "currentTermsVersion": "currentTermsVersion",
                "currentDpaVersion": "currentDpaVersion",
                "required": true
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
                  "deletedAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "name": "name",
                  "code": "code",
                  "vatCode": "vatCode",
                  "role": "role",
                  "isSandbox": true,
                  "status": "active",
                  "deletedAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Account.MeAsync(new MeAccountRequest());
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
              "timeZone": "timeZone",
              "role": "role",
              "billing": {
                "status": "trial",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "2026-07-01T09:30:00.000Z",
                "payerUserId": "payerUserId",
                "payerEmail": "payerEmail",
                "isPayer": true
              },
              "referralPoints": 1000000,
              "consent": {
                "termsVersion": "termsVersion",
                "termsAcceptedAt": "2026-07-01T09:30:00.000Z",
                "dpaVersion": "dpaVersion",
                "dpaAcceptedAt": "2026-07-01T09:30:00.000Z",
                "currentTermsVersion": "currentTermsVersion",
                "currentDpaVersion": "currentDpaVersion",
                "required": true
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
                  "deletedAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Account.MeAsync(new MeAccountRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
