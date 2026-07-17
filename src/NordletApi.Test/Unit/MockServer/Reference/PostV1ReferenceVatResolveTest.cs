using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceVatResolveTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "scheme": "domestic",
              "vatCountryCode": "vatCountryCode",
              "reverseCharge": true,
              "deemedSupplier": true,
              "zeroRated": true,
              "rates": [
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                },
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                }
              ],
              "legalBasis": "legalBasis",
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
                    .WithPath("/v1/reference/vat/resolve")
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

        var response = await Client.Reference.PostV1ReferenceVatResolveAsync(
            new PostV1ReferenceVatResolveRequest
            {
                PartnerId = null,
                CustomerCountryCode = null,
                CustomerIsBusiness = null,
                SupplyType = null,
                Date = null,
                BelowDistanceSalesThreshold = null,
                FacilitatedByMarketplace = null,
                ActingAsMarketplace = null,
                SellerEstablishedInEu = null,
                ImportedConsignmentValueEur = null,
            }
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
              "scheme": "domestic",
              "vatCountryCode": "vatCountryCode",
              "reverseCharge": true,
              "deemedSupplier": true,
              "zeroRated": true,
              "rates": [
                {
                  "category": "standard",
                  "ratePercent": "ratePercent"
                }
              ],
              "legalBasis": "legalBasis",
              "notes": [
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/vat/resolve")
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

        var response = await Client.Reference.PostV1ReferenceVatResolveAsync(
            new PostV1ReferenceVatResolveRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
