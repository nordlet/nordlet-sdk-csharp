using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsSizeCategoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "criteria": {
                "totalAssets": 1.1,
                "netTurnover": 1.1,
                "avgEmployees": 1000000
              },
              "category": "micro",
              "thresholds": {
                "thresholds": {
                  "totalAssets": 1.1,
                  "netTurnover": 1.1,
                  "employees": 1.1
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/size-category")
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

        var response = await Client.Reports.PostV1ReportsSizeCategoryAsync(
            new PostV1ReportsSizeCategoryRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "criteria": {
                "totalAssets": 1.1,
                "netTurnover": 1.1,
                "avgEmployees": 1000000
              },
              "category": "micro",
              "thresholds": {
                "key": {
                  "totalAssets": 1.1,
                  "netTurnover": 1.1,
                  "employees": 1.1
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/size-category")
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

        var response = await Client.Reports.PostV1ReportsSizeCategoryAsync(
            new PostV1ReportsSizeCategoryRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
