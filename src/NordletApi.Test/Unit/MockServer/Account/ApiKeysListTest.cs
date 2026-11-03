using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ApiKeysListTest : BaseMockServerTest
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
                  "name": "name",
                  "scopes": [
                    "scopes",
                    "scopes"
                  ],
                  "lastUsedAt": "2024-01-15T09:30:00.000Z",
                  "expiresAt": "2024-01-15T09:30:00.000Z",
                  "replacedByKeyId": "x",
                  "revokedAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "id": "x",
                  "name": "name",
                  "scopes": [
                    "scopes",
                    "scopes"
                  ],
                  "lastUsedAt": "2024-01-15T09:30:00.000Z",
                  "expiresAt": "2024-01-15T09:30:00.000Z",
                  "replacedByKeyId": "x",
                  "revokedAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/api-keys/list")
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

        var response = await Client.Account.ApiKeysListAsync(new ApiKeysListAccountRequest());
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
                  "name": "name",
                  "scopes": [
                    "scopes"
                  ],
                  "lastUsedAt": "2026-07-01T09:30:00.000Z",
                  "expiresAt": "2026-07-01T09:30:00.000Z",
                  "replacedByKeyId": "replacedByKeyId",
                  "revokedAt": "2026-07-01T09:30:00.000Z",
                  "createdAt": "2026-07-01T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/api-keys/list")
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

        var response = await Client.Account.ApiKeysListAsync(new ApiKeysListAccountRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
