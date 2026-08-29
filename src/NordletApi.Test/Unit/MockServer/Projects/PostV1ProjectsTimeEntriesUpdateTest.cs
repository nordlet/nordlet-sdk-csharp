using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Projects;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProjectsTimeEntriesUpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "projectId": "x",
              "employeeId": "x",
              "date": "date",
              "hours": "hours",
              "description": "description",
              "billable": true,
              "hourlyRate": "hourlyRate",
              "billedInvoiceId": "billedInvoiceId",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/time-entries/update")
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesUpdateAsync(
            new PostV1ProjectsTimeEntriesUpdateRequest
            {
                Id = "x",
                Date = null,
                Hours = null,
                Description = null,
                Billable = null,
                HourlyRate = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "projectId": "projectId",
              "employeeId": "employeeId",
              "date": "date",
              "hours": "hours",
              "description": "description",
              "billable": true,
              "hourlyRate": "hourlyRate",
              "billedInvoiceId": "billedInvoiceId",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/time-entries/update")
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesUpdateAsync(
            new PostV1ProjectsTimeEntriesUpdateRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
