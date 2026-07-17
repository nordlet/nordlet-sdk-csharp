using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtSdGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "type": "1-SD",
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "type": "1-SD",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "employeeId": "x",
                  "contractId": "x",
                  "contractNo": "contractNo",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "date": "date",
                  "professionCode": "professionCode",
                  "endReason": "endReason",
                  "finalInsuredIncome": "finalInsuredIncome",
                  "finalContributions": "finalContributions"
                },
                {
                  "employeeId": "x",
                  "contractId": "x",
                  "contractNo": "contractNo",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "date": "date",
                  "professionCode": "professionCode",
                  "endReason": "endReason",
                  "finalInsuredIncome": "finalInsuredIncome",
                  "finalContributions": "finalContributions"
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
                    .WithPath("/v1/declarations/lt/sd/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLtSdGenerateAsync(
            new PostV1DeclarationsLtSdGenerateRequest
            {
                Type = PostV1DeclarationsLtSdGenerateRequestType.OneSd,
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "type": "1-SD",
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "type": "1-SD",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "contractId": "contractId",
                  "contractNo": "contractNo",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "date": "date",
                  "professionCode": "professionCode",
                  "endReason": "endReason",
                  "finalInsuredIncome": "finalInsuredIncome",
                  "finalContributions": "finalContributions"
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
                    .WithPath("/v1/declarations/lt/sd/generate")
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

        var response = await Client.Declarations.PostV1DeclarationsLtSdGenerateAsync(
            new PostV1DeclarationsLtSdGenerateRequest
            {
                Type = PostV1DeclarationsLtSdGenerateRequestType.OneSd,
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
