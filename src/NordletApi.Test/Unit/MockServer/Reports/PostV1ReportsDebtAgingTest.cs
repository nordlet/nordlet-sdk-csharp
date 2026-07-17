using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReportsDebtAgingTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "asOf": "asOf",
              "side": "side",
              "rows": [
                {
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "current": "current",
                  "d1to30": "d1to30",
                  "d31to60": "d31to60",
                  "d61to90": "d61to90",
                  "over90": "over90",
                  "total": "total"
                },
                {
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "current": "current",
                  "d1to30": "d1to30",
                  "d31to60": "d31to60",
                  "d61to90": "d61to90",
                  "over90": "over90",
                  "total": "total"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/debt-aging")
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

        var response = await Client.Reports.PostV1ReportsDebtAgingAsync(
            new PostV1ReportsDebtAgingRequest { Side = null, AsOf = null }
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
              "asOf": "asOf",
              "side": "side",
              "rows": [
                {
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "current": "current",
                  "d1to30": "d1to30",
                  "d31to60": "d31to60",
                  "d61to90": "d61to90",
                  "over90": "over90",
                  "total": "total"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/debt-aging")
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

        var response = await Client.Reports.PostV1ReportsDebtAgingAsync(
            new PostV1ReportsDebtAgingRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
