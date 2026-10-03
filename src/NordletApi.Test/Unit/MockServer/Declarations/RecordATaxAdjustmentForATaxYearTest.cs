using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RecordATaxAdjustmentForATaxYearTest : BaseMockServerTest
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

        var response = await Client.Declarations.RecordATaxAdjustmentForATaxYearAsync(
            new PostV1DeclarationsTaxAdjustmentsCreateRequest
            {
                Year = 1000000,
                Kind = PostV1DeclarationsTaxAdjustmentsCreateRequestKind.NonDeductible,
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
              "amount": "amount",
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

        var response = await Client.Declarations.RecordATaxAdjustmentForATaxYearAsync(
            new PostV1DeclarationsTaxAdjustmentsCreateRequest
            {
                Year = 1000000,
                Kind = PostV1DeclarationsTaxAdjustmentsCreateRequestKind.NonDeductible,
                Amount = "amount",
                Description = "description",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
