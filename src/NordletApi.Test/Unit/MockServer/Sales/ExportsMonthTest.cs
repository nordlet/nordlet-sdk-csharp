using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ExportsMonthTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "month": "month",
              "format": "csv"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "contentType": "contentType",
              "data": "data"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/exports/month")
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

        var response = await Client.Sales.ExportsMonthAsync(
            new ExportsMonthSalesRequest
            {
                Month = "month",
                Format = ExportsMonthSalesRequestFormat.Csv,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "month": "month",
              "format": "csv"
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "contentType": "contentType",
              "data": "data"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/exports/month")
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

        var response = await Client.Sales.ExportsMonthAsync(
            new ExportsMonthSalesRequest
            {
                Month = "month",
                Format = ExportsMonthSalesRequestFormat.Csv,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
