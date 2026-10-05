using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class JobsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "reportType": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "reportType": "reportType",
              "params": {
                "key": "value"
              },
              "formats": [
                "formats",
                "formats"
              ],
              "status": "queued",
              "error": "error",
              "outputs": [
                {
                  "format": "format",
                  "fileId": "x",
                  "fileName": "fileName",
                  "sizeBytes": 1000000
                },
                {
                  "format": "format",
                  "fileId": "x",
                  "fileName": "fileName",
                  "sizeBytes": 1000000
                }
              ],
              "createdAt": "2024-01-15T09:30:00.000Z",
              "startedAt": "2024-01-15T09:30:00.000Z",
              "finishedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/jobs/create")
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

        var response = await Client.Reports.JobsCreateAsync(
            new JobsCreateReportsRequest
            {
                ReportType = "x",
                Params = null,
                Formats = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "reportType": "reportType"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "reportType": "reportType",
              "params": {
                "key": "value"
              },
              "formats": [
                "formats"
              ],
              "status": "queued",
              "error": "error",
              "outputs": [
                {
                  "format": "format",
                  "fileId": "fileId",
                  "fileName": "fileName",
                  "sizeBytes": 1000000
                }
              ],
              "createdAt": "2026-07-01T09:30:00.000Z",
              "startedAt": "2026-07-01T09:30:00.000Z",
              "finishedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/jobs/create")
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

        var response = await Client.Reports.JobsCreateAsync(
            new JobsCreateReportsRequest { ReportType = "reportType" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
