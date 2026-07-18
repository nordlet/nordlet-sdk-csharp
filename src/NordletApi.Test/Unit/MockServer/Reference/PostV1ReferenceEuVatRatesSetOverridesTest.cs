using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceEuVatRatesSetOverridesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "countryCode": "xy",
              "rates": [
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                },
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "source": "default",
              "notice": "notice",
              "rows": [
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                },
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/eu-vat-rates/set-overrides")
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

        var response = await Client.Reference.PostV1ReferenceEuVatRatesSetOverridesAsync(
            new PostV1ReferenceEuVatRatesSetOverridesRequest
            {
                CountryCode = "xy",
                Rates = new List<PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem>()
                {
                    new PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem
                    {
                        Category =
                            PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory.Standard,
                        RatePercent = "ratePercent",
                    },
                    new PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem
                    {
                        Category =
                            PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory.Standard,
                        RatePercent = "ratePercent",
                    },
                },
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
              "rates": [
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "countryCode": "countryCode",
              "source": "default",
              "notice": "notice",
              "rows": [
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/eu-vat-rates/set-overrides")
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

        var response = await Client.Reference.PostV1ReferenceEuVatRatesSetOverridesAsync(
            new PostV1ReferenceEuVatRatesSetOverridesRequest
            {
                CountryCode = "countryCode",
                Rates = new List<PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem>()
                {
                    new PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem
                    {
                        Category =
                            PostV1ReferenceEuVatRatesSetOverridesRequestRatesItemCategory.Standard,
                        RatePercent = "ratePercent",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
