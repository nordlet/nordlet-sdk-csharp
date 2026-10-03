using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IssueAReplacementForAnApiKeyAndSetTheOldOneToStopWorkingAfterAShortOverlapTest
    : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "name": "name",
              "scopes": [
                "scopes",
                "scopes"
              ],
              "key": "key",
              "expiresAt": "expiresAt",
              "replacedKeyId": "x",
              "replacedKeyExpiresAt": "replacedKeyExpiresAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/api-keys/rotate")
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
            await Client.Account.IssueAReplacementForAnApiKeyAndSetTheOldOneToStopWorkingAfterAShortOverlapAsync(
                new PostV1AccountApiKeysRotateRequest
                {
                    Id = "x",
                    OverlapHours = null,
                    ExpiresInDays = null,
                }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "name": "name",
              "scopes": [
                "scopes"
              ],
              "key": "key",
              "expiresAt": "expiresAt",
              "replacedKeyId": "replacedKeyId",
              "replacedKeyExpiresAt": "replacedKeyExpiresAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/api-keys/rotate")
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
            await Client.Account.IssueAReplacementForAnApiKeyAndSetTheOldOneToStopWorkingAfterAShortOverlapAsync(
                new PostV1AccountApiKeysRotateRequest { Id = "id" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
