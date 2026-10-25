using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoicesCardPaymentsConnectTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "returnUrl": "returnUrl",
              "refreshUrl": "refreshUrl"
            }
            """;

        const string mockResponse = """
            {
              "url": "url"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoices/card-payments/connect")
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

        var response = await Client.Sales.InvoicesCardPaymentsConnectAsync(
            new InvoicesCardPaymentsConnectSalesRequest
            {
                ReturnUrl = "returnUrl",
                RefreshUrl = "refreshUrl",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "returnUrl": "returnUrl",
              "refreshUrl": "refreshUrl"
            }
            """;

        const string mockResponse = """
            {
              "url": "url"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/invoices/card-payments/connect")
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

        var response = await Client.Sales.InvoicesCardPaymentsConnectAsync(
            new InvoicesCardPaymentsConnectSalesRequest
            {
                ReturnUrl = "returnUrl",
                RefreshUrl = "refreshUrl",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
