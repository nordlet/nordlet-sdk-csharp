using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Public;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IntegrationRequestsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "integration": "x",
              "name": "x",
              "email": "email"
            }
            """;

        const string mockResponse = """
            {
              "received": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/public/integration-requests")
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

        var response = await Client.Public.IntegrationRequestsAsync(
            new IntegrationRequestsPublicRequest
            {
                Integration = "x",
                Name = "x",
                Company = null,
                Email = "email",
                Details = null,
                Website = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "integration": "integration",
              "name": "name",
              "email": "email"
            }
            """;

        const string mockResponse = """
            {
              "received": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/public/integration-requests")
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

        var response = await Client.Public.IntegrationRequestsAsync(
            new IntegrationRequestsPublicRequest
            {
                Integration = "integration",
                Name = "name",
                Email = "email",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
