using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatProrataAdjustmentPostTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fiscalYear": 1000000,
              "accountCode": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "date": "2023-01-15",
              "fiscalYear": 1000000,
              "definitivePercent": "definitivePercent",
              "amount": "amount"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/vat-prorata/adjustment/post")
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

        var response = await Client.Declarations.VatProrataAdjustmentPostAsync(
            new VatProrataAdjustmentPostDeclarationsRequest
            {
                FiscalYear = 1000000,
                AccountCode = "x",
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
              "fiscalYear": 1000000,
              "accountCode": "accountCode"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "date": "2026-07-01",
              "fiscalYear": 1000000,
              "definitivePercent": "definitivePercent",
              "amount": "amount"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/vat-prorata/adjustment/post")
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

        var response = await Client.Declarations.VatProrataAdjustmentPostAsync(
            new VatProrataAdjustmentPostDeclarationsRequest
            {
                FiscalYear = 1000000,
                AccountCode = "accountCode",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
