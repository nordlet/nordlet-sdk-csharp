using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Calendar;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GenerateTheFileOfADeadlineForTheCompanyToSendItselfTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "key": "x"
            }
            """;

        const string mockResponse = """
            {
              "key": "key",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "variant": "variant",
              "content": "content",
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
                    .WithPath("/v1/calendar/download")
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
            await Client.Calendar.GenerateTheFileOfADeadlineForTheCompanyToSendItselfAsync(
                new PostV1CalendarDownloadRequest { Key = "x" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "key": "key"
            }
            """;

        const string mockResponse = """
            {
              "key": "key",
              "fileName": "fileName",
              "mimeType": "mimeType",
              "variant": "variant",
              "content": "content",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/calendar/download")
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
            await Client.Calendar.GenerateTheFileOfADeadlineForTheCompanyToSendItselfAsync(
                new PostV1CalendarDownloadRequest { Key = "key" }
            );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
