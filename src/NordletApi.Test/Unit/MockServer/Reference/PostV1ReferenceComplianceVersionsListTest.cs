using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceComplianceVersionsListTest : BaseMockServerTest
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
                  "country": "country",
                  "system": "system",
                  "artifact": "artifact",
                  "version": "version",
                  "verifiedOn": "verifiedOn",
                  "source": "source",
                  "resource": "resource",
                  "notes": "notes"
                },
                {
                  "country": "country",
                  "system": "system",
                  "artifact": "artifact",
                  "version": "version",
                  "verifiedOn": "verifiedOn",
                  "source": "source",
                  "resource": "resource",
                  "notes": "notes"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/compliance-versions/list")
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

        var response = await Client.Reference.PostV1ReferenceComplianceVersionsListAsync(
            new PostV1ReferenceComplianceVersionsListRequest { Country = null }
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
                  "country": "country",
                  "system": "system",
                  "artifact": "artifact",
                  "version": "version",
                  "verifiedOn": "verifiedOn",
                  "source": "source",
                  "resource": "resource",
                  "notes": "notes"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/compliance-versions/list")
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

        var response = await Client.Reference.PostV1ReferenceComplianceVersionsListAsync(
            new PostV1ReferenceComplianceVersionsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
