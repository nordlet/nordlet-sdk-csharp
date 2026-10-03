using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsEeEmploymentRegisterSendTest : BaseMockServerTest
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
              "reference": "reference",
              "state": "submitted",
              "detail": "detail",
              "fileName": "fileName",
              "entryDate": "entryDate",
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
                    .WithPath("/v1/declarations/ee/employment-register/send")
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

        var response = await Client.Declarations.PostV1DeclarationsEeEmploymentRegisterSendAsync(
            new PostV1DeclarationsEeEmploymentRegisterSendRequest
            {
                ContractId = "x",
                Event = PostV1DeclarationsEeEmploymentRegisterSendRequestEvent.Start,
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
              "reference": "reference",
              "state": "submitted",
              "detail": "detail",
              "fileName": "fileName",
              "entryDate": "entryDate",
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
                    .WithPath("/v1/declarations/ee/employment-register/send")
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

        var response = await Client.Declarations.PostV1DeclarationsEeEmploymentRegisterSendAsync(
            new PostV1DeclarationsEeEmploymentRegisterSendRequest
            {
                ContractId = "contractId",
                Event = PostV1DeclarationsEeEmploymentRegisterSendRequestEvent.Start,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
