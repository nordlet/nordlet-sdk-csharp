using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtGpm312ComputeTest : BaseMockServerTest
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
              "year": 1000000,
              "payoutTiming": "same-month",
              "payoutFrom": {
                "year": 1000000,
                "month": 1000000
              },
              "payoutTo": {
                "year": 1000000,
                "month": 1000000
              },
              "registrationNumber": "registrationNumber",
              "companyName": "companyName",
              "rows": [
                {
                  "employeeId": "x",
                  "personalCode": "personalCode",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "paymentCode": "paymentCode",
                  "paidAmount": "paidAmount",
                  "gpmWithheld": "gpmWithheld"
                },
                {
                  "employeeId": "x",
                  "personalCode": "personalCode",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "paymentCode": "paymentCode",
                  "paidAmount": "paidAmount",
                  "gpmWithheld": "gpmWithheld"
                }
              ],
              "totals": {
                "paidAmount": "paidAmount",
                "gpmWithheld": "gpmWithheld",
                "persons": 1000000
              },
              "runsFound": 1000000,
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/gpm312/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtGpm312ComputeAsync(
            new PostV1DeclarationsLtGpm312ComputeRequest { Year = 1000000, PayoutTiming = null }
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
              "year": 1000000,
              "payoutTiming": "same-month",
              "payoutFrom": {
                "year": 1000000,
                "month": 1000000
              },
              "payoutTo": {
                "year": 1000000,
                "month": 1000000
              },
              "registrationNumber": "registrationNumber",
              "companyName": "companyName",
              "rows": [
                {
                  "employeeId": "employeeId",
                  "personalCode": "personalCode",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "paymentCode": "paymentCode",
                  "paidAmount": "paidAmount",
                  "gpmWithheld": "gpmWithheld"
                }
              ],
              "totals": {
                "paidAmount": "paidAmount",
                "gpmWithheld": "gpmWithheld",
                "persons": 1000000
              },
              "runsFound": 1000000,
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/lt/gpm312/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtGpm312ComputeAsync(
            new PostV1DeclarationsLtGpm312ComputeRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
