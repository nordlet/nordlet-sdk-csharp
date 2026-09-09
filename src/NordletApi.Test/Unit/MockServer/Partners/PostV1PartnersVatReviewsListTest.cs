using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersVatReviewsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                },
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/vat-reviews/list")
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

        var response = await Client.Partners.PostV1PartnersVatReviewsListAsync(
            new PostV1PartnersVatReviewsListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
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
              "rows": [
                {
                  "id": "id",
                  "partnerId": "partnerId",
                  "vatCode": "vatCode",
                  "reason": "invalid",
                  "status": "open",
                  "resolution": "confirmed_valid",
                  "resolutionNote": "resolutionNote",
                  "details": {},
                  "resolvedAt": "resolvedAt",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/vat-reviews/list")
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

        var response = await Client.Partners.PostV1PartnersVatReviewsListAsync(
            new PostV1PartnersVatReviewsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
