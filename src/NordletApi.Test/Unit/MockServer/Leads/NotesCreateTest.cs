using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Leads;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class NotesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "leadId": "x",
              "body": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "leadId": "x",
              "body": "body",
              "authorId": "authorId",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/leads/notes/create")
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

        var response = await Client.Leads.NotesCreateAsync(
            new NotesCreateLeadsRequest { LeadId = "x", Body = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "leadId": "leadId",
              "body": "body"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "leadId": "leadId",
              "body": "body",
              "authorId": "authorId",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/leads/notes/create")
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

        var response = await Client.Leads.NotesCreateAsync(
            new NotesCreateLeadsRequest { LeadId = "leadId", Body = "body" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
