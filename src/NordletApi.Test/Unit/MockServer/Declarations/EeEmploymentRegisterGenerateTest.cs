using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EeEmploymentRegisterGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "contractId": "x",
              "event": "start"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "entryDate": "2023-01-15",
              "xml": "xml",
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/ee/employment-register/generate")
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

        var response = await Client.Declarations.EeEmploymentRegisterGenerateAsync(
            new EeEmploymentRegisterGenerateDeclarationsRequest
            {
                ContractId = "x",
                Event = EeEmploymentRegisterGenerateDeclarationsRequestEvent.Start,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "contractId": "contractId",
              "event": "start"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "entryDate": "2026-07-01",
              "xml": "xml",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/ee/employment-register/generate")
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

        var response = await Client.Declarations.EeEmploymentRegisterGenerateAsync(
            new EeEmploymentRegisterGenerateDeclarationsRequest
            {
                ContractId = "contractId",
                Event = EeEmploymentRegisterGenerateDeclarationsRequestEvent.Start,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
