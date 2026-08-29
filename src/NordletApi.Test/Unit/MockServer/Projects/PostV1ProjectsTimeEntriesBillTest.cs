using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Projects;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ProjectsTimeEntriesBillTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "projectId": "x"
            }
            """;

        const string mockResponse = """
            {
              "invoiceId": "x",
              "entryCount": 1000000,
              "hours": "hours",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/time-entries/bill")
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesBillAsync(
            new PostV1ProjectsTimeEntriesBillRequest
            {
                ProjectId = "x",
                PartnerId = null,
                DateFrom = null,
                DateTo = null,
                ItemId = null,
                HourlyRate = null,
                VatRatePercent = null,
                VatClassifierCode = null,
                IssueDate = null,
                DueDate = null,
                GroupBy = null,
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "projectId": "projectId"
            }
            """;

        const string mockResponse = """
            {
              "invoiceId": "invoiceId",
              "entryCount": 1000000,
              "hours": "hours",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "grossTotal": "grossTotal"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/projects/time-entries/bill")
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

        var response = await Client.Projects.PostV1ProjectsTimeEntriesBillAsync(
            new PostV1ProjectsTimeEntriesBillRequest { ProjectId = "projectId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
