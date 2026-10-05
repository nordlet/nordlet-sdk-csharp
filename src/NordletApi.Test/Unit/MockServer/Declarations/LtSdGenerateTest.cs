using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LtSdGenerateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "type": "1-SD",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "type": "1-SD",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "rows": [
                {
                  "employeeId": "x",
                  "contractId": "x",
                  "contractNo": "contractNo",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "date": "2023-01-15",
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
                  "date": "2023-01-15",
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

        var response = await Client.Declarations.LtSdGenerateAsync(
            new LtSdGenerateDeclarationsRequest
            {
                Type = LtSdGenerateDeclarationsRequestType.OneSd,
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
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
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "type": "1-SD",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "contractId": "contractId",
                  "contractNo": "contractNo",
                  "personalCode": "personalCode",
                  "socialInsuranceNo": "socialInsuranceNo",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "date": "2026-07-01",
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

        var response = await Client.Declarations.LtSdGenerateAsync(
            new LtSdGenerateDeclarationsRequest
            {
                Type = LtSdGenerateDeclarationsRequestType.OneSd,
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
