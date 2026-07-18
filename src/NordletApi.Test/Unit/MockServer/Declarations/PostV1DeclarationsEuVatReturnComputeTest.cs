using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsEuVatReturnComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "countryCode": "xy",
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "formKey": "formKey",
              "formName": "formName",
              "frequency": "monthly",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "boxes": [
                {
                  "code": "code",
                  "label": "label",
                  "amount": "amount"
                },
                {
                  "code": "code",
                  "label": "label",
                  "amount": "amount"
                }
              ],
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
                    .WithPath("/v1/declarations/eu/vat-return/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsEuVatReturnComputeAsync(
            new PostV1DeclarationsEuVatReturnComputeRequest
            {
                CountryCode = "xy",
                Year = 1000000,
                Month = 1000000,
                Months = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "countryCode": "countryCode",
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "formKey": "formKey",
              "formName": "formName",
              "frequency": "monthly",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "boxes": [
                {
                  "code": "code",
                  "label": "label",
                  "amount": "amount"
                }
              ],
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
                    .WithPath("/v1/declarations/eu/vat-return/compute")
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

        var response = await Client.Declarations.PostV1DeclarationsEuVatReturnComputeAsync(
            new PostV1DeclarationsEuVatReturnComputeRequest
            {
                CountryCode = "countryCode",
                Year = 1000000,
                Month = 1000000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
