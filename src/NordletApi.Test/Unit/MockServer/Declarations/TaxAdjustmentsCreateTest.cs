using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TaxAdjustmentsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "kind": "non_deductible",
              "amount": "amount",
              "description": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "year": 1000000,
              "kind": "non_deductible",
              "code": "code",
              "amount": "amount",
              "description": "description"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-adjustments/create")
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

        var response = await Client.Declarations.TaxAdjustmentsCreateAsync(
            new TaxAdjustmentsCreateDeclarationsRequest
            {
                Year = 1000000,
                Kind = TaxAdjustmentsCreateDeclarationsRequestKind.NonDeductible,
                Code = null,
                Amount = "amount",
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
              "year": 1000000,
              "kind": "non_deductible",
              "amount": "121.00",
              "description": "description"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "year": 1000000,
              "kind": "non_deductible",
              "code": "code",
              "amount": "amount",
              "description": "description"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-adjustments/create")
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

        var response = await Client.Declarations.TaxAdjustmentsCreateAsync(
            new TaxAdjustmentsCreateDeclarationsRequest
            {
                Year = 1000000,
                Kind = TaxAdjustmentsCreateDeclarationsRequestKind.NonDeductible,
                Amount = "121.00",
                Description = "description",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
