using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsEuOssComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "periodYear": 1000000,
              "fromDate": "fromDate",
              "toDate": "toDate",
              "memberStateOfIdentification": "memberStateOfIdentification",
              "rows": [
                {
                  "countryCode": "countryCode",
                  "rateType": "STANDARD",
                  "vatRatePercent": "vatRatePercent",
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "documents": 1000000
                },
                {
                  "countryCode": "countryCode",
                  "rateType": "STANDARD",
                  "vatRatePercent": "vatRatePercent",
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "documents": 1000000
                }
              ],
              "totals": {
                "taxableAmount": "taxableAmount",
                "vatAmount": "vatAmount"
              },
              "corrections": [
                {
                  "countryCode": "countryCode",
                  "periodYear": 1000000,
                  "periodQuarter": 1000000,
                  "periodMonth": 1000000,
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "documents": 1000000
                },
                {
                  "countryCode": "countryCode",
                  "periodYear": 1000000,
                  "periodQuarter": 1000000,
                  "periodMonth": 1000000,
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "documents": 1000000
                }
              ],
              "correctionsTotal": {
                "taxableAmount": "taxableAmount",
                "vatAmount": "vatAmount"
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "periodQuarter": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/oss/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsEuOssComputeAsync(
            new PostV1DeclarationsEuOssComputeRequest { Year = 1000000, Quarter = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "periodYear": 1000000,
              "fromDate": "fromDate",
              "toDate": "toDate",
              "memberStateOfIdentification": "memberStateOfIdentification",
              "rows": [
                {
                  "countryCode": "countryCode",
                  "rateType": "STANDARD",
                  "vatRatePercent": "vatRatePercent",
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "documents": 1000000
                }
              ],
              "totals": {
                "taxableAmount": "taxableAmount",
                "vatAmount": "vatAmount"
              },
              "corrections": [
                {
                  "countryCode": "countryCode",
                  "periodYear": 1000000,
                  "periodQuarter": 1000000,
                  "periodMonth": 1000000,
                  "taxableAmount": "taxableAmount",
                  "vatAmount": "vatAmount",
                  "documents": 1000000
                }
              ],
              "correctionsTotal": {
                "taxableAmount": "taxableAmount",
                "vatAmount": "vatAmount"
              },
              "warnings": [
                "warnings"
              ],
              "periodQuarter": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/oss/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsEuOssComputeAsync(
            new PostV1DeclarationsEuOssComputeRequest { Year = 1000000, Quarter = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
