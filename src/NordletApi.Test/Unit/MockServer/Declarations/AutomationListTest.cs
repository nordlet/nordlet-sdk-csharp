using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AutomationListTest : BaseMockServerTest
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
                  "ruleKey": "ruleKey",
                  "title": "title",
                  "country": "country",
                  "system": "system",
                  "enabled": true,
                  "applies": true,
                  "configured": true,
                  "certificate": "ok",
                  "environment": "test"
                },
                {
                  "ruleKey": "ruleKey",
                  "title": "title",
                  "country": "country",
                  "system": "system",
                  "enabled": true,
                  "applies": true,
                  "configured": true,
                  "certificate": "ok",
                  "environment": "test"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/automation/list")
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

        var response = await Client.Declarations.AutomationListAsync(
            new AutomationListDeclarationsRequest()
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
              "rows": [
                {
                  "ruleKey": "ruleKey",
                  "title": "title",
                  "country": "country",
                  "system": "system",
                  "enabled": true,
                  "applies": true,
                  "configured": true,
                  "certificate": "ok",
                  "environment": "test"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/automation/list")
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

        var response = await Client.Declarations.AutomationListAsync(
            new AutomationListDeclarationsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
