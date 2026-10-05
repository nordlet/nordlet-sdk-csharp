using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EuVatRatesListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "notice": "notice",
              "rows": [
                {
                  "countryCode": "countryCode",
                  "category": "standard",
                  "ratePercent": "ratePercent",
                  "validFrom": "validFrom",
                  "validTo": "validTo",
                  "source": "default"
                },
                {
                  "countryCode": "countryCode",
                  "category": "standard",
                  "ratePercent": "ratePercent",
                  "validFrom": "validFrom",
                  "validTo": "validTo",
                  "source": "default"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/eu-vat-rates/list")
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

        var response = await Client.Reference.EuVatRatesListAsync(
            new EuVatRatesListReferenceRequest { CountryCode = null, Date = null }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "notice": "notice",
              "rows": [
                {
                  "countryCode": "countryCode",
                  "category": "standard",
                  "ratePercent": "ratePercent",
                  "validFrom": "validFrom",
                  "validTo": "validTo",
                  "source": "default"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/eu-vat-rates/list")
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

        var response = await Client.Reference.EuVatRatesListAsync(
            new EuVatRatesListReferenceRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
