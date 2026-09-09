using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Calendar;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CalendarUpdateTest : BaseMockServerTest
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
              "key": "x",
              "id": "x",
              "kind": "custom",
              "ruleKey": "ruleKey",
              "period": "period",
              "title": "title",
              "dueDate": "dueDate",
              "notes": "notes",
              "done": true,
              "href": "href"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/calendar/update")
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

        var response = await Client.Calendar.PostV1CalendarUpdateAsync(
            new PostV1CalendarUpdateRequest
            {
                Key = "x",
                Title = null,
                DueDate = null,
                Notes = null,
                Done = null,
            }
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
              "id": "id",
              "kind": "custom",
              "ruleKey": "ruleKey",
              "period": "period",
              "title": "title",
              "dueDate": "dueDate",
              "notes": "notes",
              "done": true,
              "href": "href"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/calendar/update")
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

        var response = await Client.Calendar.PostV1CalendarUpdateAsync(
            new PostV1CalendarUpdateRequest { Key = "key" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
