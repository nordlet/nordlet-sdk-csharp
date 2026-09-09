using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Calendar;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CalendarCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "title": "x",
              "dueDate": "dueDate"
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
                    .WithPath("/v1/calendar/create")
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

        var response = await Client.Calendar.PostV1CalendarCreateAsync(
            new PostV1CalendarCreateRequest
            {
                Title = "x",
                DueDate = "dueDate",
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
              "title": "title",
              "dueDate": "dueDate"
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
                    .WithPath("/v1/calendar/create")
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

        var response = await Client.Calendar.PostV1CalendarCreateAsync(
            new PostV1CalendarCreateRequest { Title = "title", DueDate = "dueDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
