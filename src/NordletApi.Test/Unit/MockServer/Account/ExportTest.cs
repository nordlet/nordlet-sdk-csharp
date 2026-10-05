using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ExportTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "generatedAt": "2024-01-15T09:30:00.000Z",
              "user": {
                "id": "x",
                "email": "email",
                "name": "name",
                "locale": "locale",
                "plan": "plan",
                "createdAt": "2024-01-15T09:30:00.000Z"
              },
              "consent": {
                "termsVersion": "termsVersion",
                "termsAcceptedAt": "2024-01-15T09:30:00.000Z",
                "dpaVersion": "dpaVersion",
                "dpaAcceptedAt": "2024-01-15T09:30:00.000Z",
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
                  "ipAddress": "ipAddress",
                  "userAgent": "userAgent",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "expiresAt": "2024-01-15T09:30:00.000Z",
                  "current": true
                },
                {
                  "id": "x",
                  "companyId": "x",
                  "ipAddress": "ipAddress",
                  "userAgent": "userAgent",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "expiresAt": "2024-01-15T09:30:00.000Z",
                  "current": true
                }
              ],
              "billing": {
                "status": "status",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "2024-01-15T09:30:00.000Z",
                "firstTopUpAt": "2024-01-15T09:30:00.000Z"
              },
              "creditTransactions": [
                {
                  "id": "x",
                  "type": "type",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "type": "type",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "auditEntries": [
                {
                  "id": 1000000,
                  "companyId": "x",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": 1000000,
                  "companyId": "x",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "createdAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Account.ExportAsync(new ExportAccountRequest());
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
              "generatedAt": "2026-07-01T09:30:00.000Z",
              "user": {
                "id": "id",
                "email": "email",
                "name": "name",
                "locale": "locale",
                "plan": "plan",
                "createdAt": "2026-07-01T09:30:00.000Z"
              },
              "consent": {
                "termsVersion": "termsVersion",
                "termsAcceptedAt": "2026-07-01T09:30:00.000Z",
                "dpaVersion": "dpaVersion",
                "dpaAcceptedAt": "2026-07-01T09:30:00.000Z",
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
                  "ipAddress": "ipAddress",
                  "userAgent": "userAgent",
                  "lastSeenAt": "2026-07-01T09:30:00.000Z",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "expiresAt": "2026-07-01T09:30:00.000Z",
                  "current": true
                }
              ],
              "billing": {
                "status": "status",
                "plan": "plan",
                "balanceCents": 1000000,
                "trialEndsAt": "2026-07-01T09:30:00.000Z",
                "firstTopUpAt": "2026-07-01T09:30:00.000Z"
              },
              "creditTransactions": [
                {
                  "id": "id",
                  "type": "type",
                  "amountCents": 1000000,
                  "balanceAfterCents": 1000000,
                  "description": "description",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ],
              "auditEntries": [
                {
                  "id": 1000000,
                  "companyId": "companyId",
                  "action": "action",
                  "entity": "entity",
                  "entityId": "entityId",
                  "createdAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Account.ExportAsync(new ExportAccountRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
