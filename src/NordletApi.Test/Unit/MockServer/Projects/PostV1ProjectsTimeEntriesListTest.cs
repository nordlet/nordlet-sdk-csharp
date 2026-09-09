using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Projects;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProjectsTimeEntriesListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                },
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/time-entries/list")
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesListAsync(
            new PostV1ProjectsTimeEntriesListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/time-entries/list")
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesListAsync(
            new PostV1ProjectsTimeEntriesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
