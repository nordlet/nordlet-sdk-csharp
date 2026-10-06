using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reports;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PartnerBalancesTest : BaseMockServerTest
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
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "receivable": "receivable",
                  "payable": "payable",
                  "net": "net"
                },
                {
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "receivable": "receivable",
                  "payable": "payable",
                  "net": "net"
                }
              ],
              "totals": {
                "receivable": "receivable",
                "payable": "payable"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/partner-balances")
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

        var response = await Client.Reports.PartnerBalancesAsync(
            new PartnerBalancesReportsRequest()
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
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "receivable": "receivable",
                  "payable": "payable",
                  "net": "net"
                }
              ],
              "totals": {
                "receivable": "receivable",
                "payable": "payable"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reports/partner-balances")
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

        var response = await Client.Reports.PartnerBalancesAsync(
            new PartnerBalancesReportsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
