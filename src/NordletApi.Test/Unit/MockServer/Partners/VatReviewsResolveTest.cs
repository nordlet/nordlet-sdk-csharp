using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatReviewsResolveTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "resolution": "confirmed_valid"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "partnerId": "x",
              "vatCode": "vatCode",
              "reason": "invalid",
              "status": "open",
              "resolution": "confirmed_valid",
              "resolutionNote": "resolutionNote",
              "details": {
                "message": "message",
                "partnerName": "partnerName",
                "viesName": "viesName",
                "viesAddress": "viesAddress",
                "requestIdentifier": "requestIdentifier"
              },
              "resolvedAt": "2024-01-15T09:30:00.000Z",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/vat-reviews/resolve")
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

        var response = await Client.Partners.VatReviewsResolveAsync(
            new VatReviewsResolvePartnersRequest
            {
                Id = "x",
                Resolution = VatReviewsResolvePartnersRequestResolution.ConfirmedValid,
                Note = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "resolution": "confirmed_valid"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "partnerId": "partnerId",
              "vatCode": "vatCode",
              "reason": "invalid",
              "status": "open",
              "resolution": "confirmed_valid",
              "resolutionNote": "resolutionNote",
              "details": {
                "message": "message",
                "partnerName": "partnerName",
                "viesName": "viesName",
                "viesAddress": "viesAddress",
                "requestIdentifier": "requestIdentifier"
              },
              "resolvedAt": "2026-07-01T09:30:00.000Z",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/vat-reviews/resolve")
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

        var response = await Client.Partners.VatReviewsResolveAsync(
            new VatReviewsResolvePartnersRequest
            {
                Id = "id",
                Resolution = VatReviewsResolvePartnersRequestResolution.ConfirmedValid,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
