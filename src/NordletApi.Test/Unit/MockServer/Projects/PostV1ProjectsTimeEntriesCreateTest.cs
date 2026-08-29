using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Projects;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProjectsTimeEntriesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "projectId": "x",
              "date": "date",
              "hours": "hours"
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesCreateAsync(
            new PostV1ProjectsTimeEntriesCreateRequest
            {
                ProjectId = "x",
                EmployeeId = null,
                Date = "date",
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
              "date": "date",
              "hours": "hours"
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesCreateAsync(
            new PostV1ProjectsTimeEntriesCreateRequest
            {
                ProjectId = "projectId",
                Date = "date",
                Hours = "hours",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
