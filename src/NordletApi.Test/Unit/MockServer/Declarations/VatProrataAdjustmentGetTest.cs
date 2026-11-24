using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatProrataAdjustmentGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fiscalYear": 1000000
            }
            """;

        const string mockResponse = """
            {
              "fiscalYear": 1000000,
              "provisionalPercent": "provisionalPercent",
              "computedPercent": "computedPercent",
              "definitivePercent": "definitivePercent",
              "turnoverWithDeduction": "turnoverWithDeduction",
              "turnoverWithoutDeduction": "turnoverWithoutDeduction",
              "capitalGoodsSales": "capitalGoodsSales",
              "proRataVat": "proRataVat",
              "deductedVat": "deductedVat",
              "definitiveDeductibleVat": "definitiveDeductibleVat",
              "adjustment": "adjustment",
              "warnings": [
                "warnings",
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/vat-prorata/adjustment/get")
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

        var response = await Client.Declarations.VatProrataAdjustmentGetAsync(
            new VatProrataAdjustmentGetDeclarationsRequest
            {
                FiscalYear = 1000000,
                DefinitivePercent = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fiscalYear": 1000000
            }
            """;

        const string mockResponse = """
            {
              "fiscalYear": 1000000,
              "provisionalPercent": "provisionalPercent",
              "computedPercent": "computedPercent",
              "definitivePercent": "definitivePercent",
              "turnoverWithDeduction": "turnoverWithDeduction",
              "turnoverWithoutDeduction": "turnoverWithoutDeduction",
              "capitalGoodsSales": "capitalGoodsSales",
              "proRataVat": "proRataVat",
              "deductedVat": "deductedVat",
              "definitiveDeductibleVat": "definitiveDeductibleVat",
              "adjustment": "adjustment",
              "warnings": [
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/vat-prorata/adjustment/get")
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

        var response = await Client.Declarations.VatProrataAdjustmentGetAsync(
            new VatProrataAdjustmentGetDeclarationsRequest { FiscalYear = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
