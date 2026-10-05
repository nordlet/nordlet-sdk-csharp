using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Projects;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TimeEntriesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "projectId": "x",
              "date": "2023-01-15",
              "hours": "hours"
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
                    .WithPath("/v1/projects/time-entries/create")
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

        var response = await Client.Projects.TimeEntriesCreateAsync(
            new TimeEntriesCreateProjectsRequest
            {
                ProjectId = "x",
                EmployeeId = null,
                Date = new DateOnly(2023, 1, 15),
                Hours = "hours",
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
              "projectId": "projectId",
              "date": "2026-07-01",
              "hours": "121.00"
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
                    .WithPath("/v1/projects/time-entries/create")
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

        var response = await Client.Projects.TimeEntriesCreateAsync(
            new TimeEntriesCreateProjectsRequest
            {
                ProjectId = "projectId",
                Date = new DateOnly(2026, 7, 1),
                Hours = "121.00",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
