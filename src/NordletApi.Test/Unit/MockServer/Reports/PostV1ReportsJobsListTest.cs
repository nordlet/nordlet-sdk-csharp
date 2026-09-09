using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsJobsListTest : BaseMockServerTest
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
                  "createdAt": "createdAt",
                  "startedAt": "startedAt",
                  "finishedAt": "finishedAt"
                },
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
                  "createdAt": "createdAt",
                  "startedAt": "startedAt",
                  "finishedAt": "finishedAt"
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
                    .WithPath("/v1/reports/jobs/list")
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

        var response = await Client.Reports.PostV1ReportsJobsListAsync(
            new PostV1ReportsJobsListRequest
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
                  "createdAt": "createdAt",
                  "startedAt": "startedAt",
                  "finishedAt": "finishedAt"
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
                    .WithPath("/v1/reports/jobs/list")
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

        var response = await Client.Reports.PostV1ReportsJobsListAsync(
            new PostV1ReportsJobsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
