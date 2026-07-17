using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtSamComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "month": 1000000,
              "insuredCount": 1000000,
              "insuredIncomeTotal": "insuredIncomeTotal",
              "contributionsTotal": "contributionsTotal",
              "persons": [
                {
                  "employeeId": "x",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "insuredIncome": "insuredIncome",
                  "contributions": "contributions",
                  "tariffPercent": "tariffPercent"
                },
                {
                  "employeeId": "x",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "insuredIncome": "insuredIncome",
                  "contributions": "contributions",
                  "tariffPercent": "tariffPercent"
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/sam/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtSamComputeAsync(
            new PostV1DeclarationsLtSamComputeRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1000000,
              "month": 1000000,
              "insuredCount": 1000000,
              "insuredIncomeTotal": "insuredIncomeTotal",
              "contributionsTotal": "contributionsTotal",
              "persons": [
                {
                  "employeeId": "employeeId",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "insuredIncome": "insuredIncome",
                  "contributions": "contributions",
                  "tariffPercent": "tariffPercent"
                }
              ],
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/sam/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtSamComputeAsync(
            new PostV1DeclarationsLtSamComputeRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
