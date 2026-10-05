using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Projects;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TimeEntriesUpdateTest : BaseMockServerTest
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
              "date": "2023-01-15",
              "hours": "hours",
              "description": "description",
              "billable": true,
              "hourlyRate": "hourlyRate",
              "billedInvoiceId": "billedInvoiceId",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Projects.TimeEntriesUpdateAsync(
            new TimeEntriesUpdateProjectsRequest
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
              "date": "2026-07-01",
              "hours": "hours",
              "description": "description",
              "billable": true,
              "hourlyRate": "hourlyRate",
              "billedInvoiceId": "billedInvoiceId",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Projects.TimeEntriesUpdateAsync(
            new TimeEntriesUpdateProjectsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
