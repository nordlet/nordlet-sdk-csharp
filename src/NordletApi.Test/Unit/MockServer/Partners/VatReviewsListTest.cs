using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class VatReviewsListTest : BaseMockServerTest
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
                  "resolvedAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                  "resolvedAt": "2024-01-15T09:30:00.000Z",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Partners.VatReviewsListAsync(
            new VatReviewsListPartnersRequest
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
                  "resolvedAt": "2026-07-01T09:30:00.000Z",
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Partners.VatReviewsListAsync(
            new VatReviewsListPartnersRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
