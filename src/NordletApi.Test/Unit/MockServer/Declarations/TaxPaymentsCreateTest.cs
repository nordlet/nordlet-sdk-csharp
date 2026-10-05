using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TaxPaymentsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "tax": "corporate_income_tax",
              "year": 1000000,
              "kind": "advance",
              "amount": "amount",
              "paidOn": "2023-01-15",
              "description": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-payments/create")
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

        var response = await Client.Declarations.TaxPaymentsCreateAsync(
            new TaxPaymentsCreateDeclarationsRequest
            {
                Tax = TaxPaymentsCreateDeclarationsRequestTax.CorporateIncomeTax,
                Year = 1000000,
                Month = null,
                Kind = TaxPaymentsCreateDeclarationsRequestKind.Advance,
                Amount = "amount",
                PaidOn = new DateOnly(2023, 1, 15),
                Reference = null,
                Description = "x",
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
              "year": 1000000,
              "kind": "advance",
              "amount": "121.00",
              "paidOn": "2026-07-01",
              "description": "description"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-payments/create")
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

        var response = await Client.Declarations.TaxPaymentsCreateAsync(
            new TaxPaymentsCreateDeclarationsRequest
            {
                Tax = TaxPaymentsCreateDeclarationsRequestTax.CorporateIncomeTax,
                Year = 1000000,
                Kind = TaxPaymentsCreateDeclarationsRequestKind.Advance,
                Amount = "121.00",
                PaidOn = new DateOnly(2026, 7, 1),
                Description = "description",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
