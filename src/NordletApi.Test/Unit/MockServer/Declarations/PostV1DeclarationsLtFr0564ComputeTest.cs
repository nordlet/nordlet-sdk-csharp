using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsLtFr0564ComputeTest : BaseMockServerTest
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
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "registrationNumber": "registrationNumber",
              "vatCode": "vatCode",
              "companyName": "companyName",
              "rows": [
                {
                  "vatCode": "vatCode",
                  "partnerName": "partnerName",
                  "countryCode": "countryCode",
                  "goods": "goods",
                  "triangular": "triangular",
                  "services": "services"
                },
                {
                  "vatCode": "vatCode",
                  "partnerName": "partnerName",
                  "countryCode": "countryCode",
                  "goods": "goods",
                  "triangular": "triangular",
                  "services": "services"
                }
              ],
              "totals": {
                "goods": "goods",
                "triangular": "triangular",
                "services": "services",
                "rows": 1000000
              },
              "counts": {
                "salesInvoices": 1000000
              },
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
                    .WithPath("/v1/declarations/lt/fr0564/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtFr0564ComputeAsync(
            new PostV1DeclarationsLtFr0564ComputeRequest { Year = 1000000, Month = 1000000 }
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
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "registrationNumber": "registrationNumber",
              "vatCode": "vatCode",
              "companyName": "companyName",
              "rows": [
                {
                  "vatCode": "vatCode",
                  "partnerName": "partnerName",
                  "countryCode": "countryCode",
                  "goods": "goods",
                  "triangular": "triangular",
                  "services": "services"
                }
              ],
              "totals": {
                "goods": "goods",
                "triangular": "triangular",
                "services": "services",
                "rows": 1000000
              },
              "counts": {
                "salesInvoices": 1000000
              },
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
                    .WithPath("/v1/declarations/lt/fr0564/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsLtFr0564ComputeAsync(
            new PostV1DeclarationsLtFr0564ComputeRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
