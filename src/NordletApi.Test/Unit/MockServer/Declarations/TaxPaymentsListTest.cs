using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TaxPaymentsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "tax": "corporate_income_tax",
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "x",
                  "tax": "tax",
                  "year": 1000000,
                  "month": 1000000,
                  "kind": "advance",
                  "amount": "amount",
                  "paidOn": "paidOn",
                  "reference": "reference",
                  "description": "description"
                },
                {
                  "id": "x",
                  "tax": "tax",
                  "year": 1000000,
                  "month": 1000000,
                  "kind": "advance",
                  "amount": "amount",
                  "paidOn": "paidOn",
                  "reference": "reference",
                  "description": "description"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-payments/list")
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

        var response = await Client.Declarations.TaxPaymentsListAsync(
            new TaxPaymentsListDeclarationsRequest
            {
                Tax = TaxPaymentsListDeclarationsRequestTax.CorporateIncomeTax,
                Year = 1000000,
                Month = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "tax": "corporate_income_tax",
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "id",
                  "tax": "tax",
                  "year": 1000000,
                  "month": 1000000,
                  "kind": "advance",
                  "amount": "amount",
                  "paidOn": "paidOn",
                  "reference": "reference",
                  "description": "description"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-payments/list")
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

        var response = await Client.Declarations.TaxPaymentsListAsync(
            new TaxPaymentsListDeclarationsRequest
            {
                Tax = TaxPaymentsListDeclarationsRequestTax.CorporateIncomeTax,
                Year = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
