using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TaxAdjustmentsRecordedForATaxYearTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "x",
                  "year": 1000000,
                  "kind": "non_deductible",
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                },
                {
                  "id": "x",
                  "year": 1000000,
                  "kind": "non_deductible",
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-adjustments/list")
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

        var response = await Client.Declarations.TaxAdjustmentsRecordedForATaxYearAsync(
            new PostV1DeclarationsTaxAdjustmentsListRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "id",
                  "year": 1000000,
                  "kind": "non_deductible",
                  "code": "code",
                  "amount": "amount",
                  "description": "description"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/tax-adjustments/list")
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

        var response = await Client.Declarations.TaxAdjustmentsRecordedForATaxYearAsync(
            new PostV1DeclarationsTaxAdjustmentsListRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
