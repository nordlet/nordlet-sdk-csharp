using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Projects;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProjectsReportTest : BaseMockServerTest
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
                  "projectId": "x",
                  "code": "code",
                  "name": "name",
                  "status": "active",
                  "revenue": "revenue",
                  "costs": "costs",
                  "profit": "profit",
                  "totalHours": "totalHours",
                  "billableHours": "billableHours",
                  "billedHours": "billedHours",
                  "unbilledHours": "unbilledHours",
                  "unbilledAmount": "unbilledAmount"
                },
                {
                  "projectId": "x",
                  "code": "code",
                  "name": "name",
                  "status": "active",
                  "revenue": "revenue",
                  "costs": "costs",
                  "profit": "profit",
                  "totalHours": "totalHours",
                  "billableHours": "billableHours",
                  "billedHours": "billedHours",
                  "unbilledHours": "unbilledHours",
                  "unbilledAmount": "unbilledAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/report")
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

        var response = await Client.Projects.PostV1ProjectsReportAsync(
            new PostV1ProjectsReportRequest
            {
                ProjectId = null,
                DateFrom = null,
                DateTo = null,
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
                  "projectId": "projectId",
                  "code": "code",
                  "name": "name",
                  "status": "active",
                  "revenue": "revenue",
                  "costs": "costs",
                  "profit": "profit",
                  "totalHours": "totalHours",
                  "billableHours": "billableHours",
                  "billedHours": "billedHours",
                  "unbilledHours": "unbilledHours",
                  "unbilledAmount": "unbilledAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/report")
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

        var response = await Client.Projects.PostV1ProjectsReportAsync(
            new PostV1ProjectsReportRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
