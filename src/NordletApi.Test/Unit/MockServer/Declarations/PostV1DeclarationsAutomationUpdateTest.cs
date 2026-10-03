using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsAutomationUpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "ruleKey": "x",
              "enabled": true
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "ruleKey": "ruleKey",
                  "title": "title",
                  "country": "country",
                  "system": "system",
                  "enabled": true,
                  "applies": true,
                  "configured": true,
                  "certificate": "ok"
                },
                {
                  "ruleKey": "ruleKey",
                  "title": "title",
                  "country": "country",
                  "system": "system",
                  "enabled": true,
                  "applies": true,
                  "configured": true,
                  "certificate": "ok"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/automation/update")
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

        var response = await Client.Declarations.PostV1DeclarationsAutomationUpdateAsync(
            new PostV1DeclarationsAutomationUpdateRequest { RuleKey = "x", Enabled = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "ruleKey": "ruleKey",
              "enabled": true
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "ruleKey": "ruleKey",
                  "title": "title",
                  "country": "country",
                  "system": "system",
                  "enabled": true,
                  "applies": true,
                  "configured": true,
                  "certificate": "ok"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/automation/update")
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

        var response = await Client.Declarations.PostV1DeclarationsAutomationUpdateAsync(
            new PostV1DeclarationsAutomationUpdateRequest { RuleKey = "ruleKey", Enabled = true }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
