using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EuSmeCrossBorderReportComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "quarter": 1000000,
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "currency": "currency",
              "rows": [
                {
                  "countryCode": "countryCode",
                  "amount": "amount",
                  "documents": 1000000
                },
                {
                  "countryCode": "countryCode",
                  "amount": "amount",
                  "documents": 1000000
                }
              ],
              "total": "total",
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/sme-cross-border-report/compute")
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

        var response = await Client.Declarations.EuSmeCrossBorderReportComputeAsync(
            new EuSmeCrossBorderReportComputeDeclarationsRequest
            {
                Year = 1000000,
                Quarter = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "quarter": 1000000,
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "currency": "currency",
              "rows": [
                {
                  "countryCode": "countryCode",
                  "amount": "amount",
                  "documents": 1000000
                }
              ],
              "total": "total",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/sme-cross-border-report/compute")
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

        var response = await Client.Declarations.EuSmeCrossBorderReportComputeAsync(
            new EuSmeCrossBorderReportComputeDeclarationsRequest
            {
                Year = 1000000,
                Quarter = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
