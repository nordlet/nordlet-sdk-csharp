using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DownloadEverythingNordletStoresAboutTheSignedInUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "generatedAt": "generatedAt",
              "user": {
                "id": "x",
                "email": "email",
                "name": "name",
                "locale": "locale",
                "plan": "plan",
                "createdAt": "createdAt"
              },
              "consent": {
                "termsVersion": "termsVersion",
                "termsAcceptedAt": "termsAcceptedAt",
                "dpaVersion": "dpaVersion",
                "dpaAcceptedAt": "dpaAcceptedAt",
                "currentTermsVersion": "currentTermsVersion",
                "currentDpaVersion": "currentDpaVersion",
                "required": true
              },
              "memberships": [
                {
                  "companyId": "x",
                  "companyName": "companyName",
                  "role": "role",
                  "since": "since"
                },
                {
                  "companyId": "x",
                  "companyName": "companyName",
                  "role": "role",
                  "since": "since"
                }
              ],
              "sessions": [
                {
                  "id": "x",
                  "companyId": "x",
                  "createdAt": "createdAt",
                  "expiresAt": "expiresAt",
                  "current": true
                },
                {
                  "id": "x",
                  "companyId": "x",
                  "createdAt": "createdAt",
                  "expiresAt": "expiresAt",
                  "current": true
                }
              ],
              "billing": {
                "status": "status",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "trialEndsAt",
                "firstTopUpAt": "firstTopUpAt"
              },
              "creditTransactions": [
                {
                  "id": "x",
                  "type": "type",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "type": "type",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "createdAt": "createdAt"
                }
              ],
              "auditEntries": [
                {
                  "id": 1000000,
                  "companyId": "x",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "createdAt": "createdAt"
                },
                {
                  "id": 1000000,
                  "companyId": "x",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/export")
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

        var response =
            await Client.Account.DownloadEverythingNordletStoresAboutTheSignedInUserAsync(
                new PostV1AccountExportRequest()
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
              "generatedAt": "generatedAt",
              "user": {
                "id": "id",
                "email": "email",
                "name": "name",
                "locale": "locale",
                "plan": "plan",
                "createdAt": "createdAt"
              },
              "consent": {
                "termsVersion": "termsVersion",
                "termsAcceptedAt": "termsAcceptedAt",
                "dpaVersion": "dpaVersion",
                "dpaAcceptedAt": "dpaAcceptedAt",
                "currentTermsVersion": "currentTermsVersion",
                "currentDpaVersion": "currentDpaVersion",
                "required": true
              },
              "memberships": [
                {
                  "companyId": "companyId",
                  "companyName": "companyName",
                  "role": "role",
                  "since": "since"
                }
              ],
              "sessions": [
                {
                  "id": "id",
                  "companyId": "companyId",
                  "createdAt": "createdAt",
                  "expiresAt": "expiresAt",
                  "current": true
                }
              ],
              "billing": {
                "status": "status",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "trialEndsAt",
                "firstTopUpAt": "firstTopUpAt"
              },
              "creditTransactions": [
                {
                  "id": "id",
                  "type": "type",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "createdAt": "createdAt"
                }
              ],
              "auditEntries": [
                {
                  "id": 1000000,
                  "companyId": "companyId",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/export")
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

        var response =
            await Client.Account.DownloadEverythingNordletStoresAboutTheSignedInUserAsync(
                new PostV1AccountExportRequest()
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
