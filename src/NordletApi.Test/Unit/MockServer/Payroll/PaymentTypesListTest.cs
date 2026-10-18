using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PaymentTypesListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "defaultPaymentType": "defaultPaymentType",
              "rows": [
                {
                  "code": "code",
                  "name": "name",
                  "applies": [
                    "applies",
                    "applies"
                  ]
                },
                {
                  "code": "code",
                  "name": "name",
                  "applies": [
                    "applies",
                    "applies"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/payment-types/list")
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

        var response = await Client.Payroll.PaymentTypesListAsync(
            new PaymentTypesListPayrollRequest()
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
              "countryCode": "countryCode",
              "defaultPaymentType": "defaultPaymentType",
              "rows": [
                {
                  "code": "code",
                  "name": "name",
                  "applies": [
                    "applies"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/payment-types/list")
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

        var response = await Client.Payroll.PaymentTypesListAsync(
            new PaymentTypesListPayrollRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
