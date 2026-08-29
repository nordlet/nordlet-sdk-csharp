using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersVatReviewsResolveTest : BaseMockServerTest
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
              "resolvedAt": "resolvedAt",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
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

        var response = await Client.Partners.PostV1PartnersVatReviewsResolveAsync(
            new PostV1PartnersVatReviewsResolveRequest
            {
                Id = "x",
                Resolution = PostV1PartnersVatReviewsResolveRequestResolution.ConfirmedValid,
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
              "resolvedAt": "resolvedAt",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
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

        var response = await Client.Partners.PostV1PartnersVatReviewsResolveAsync(
            new PostV1PartnersVatReviewsResolveRequest
            {
                Id = "id",
                Resolution = PostV1PartnersVatReviewsResolveRequestResolution.ConfirmedValid,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
