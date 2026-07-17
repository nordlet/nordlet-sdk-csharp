using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersInquiriesListTest : BaseMockServerTest
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
                  "partnerName": "partnerName",
                  "contactName": "contactName",
                  "contactEmail": "contactEmail",
                  "contactPhone": "contactPhone",
                  "subject": "subject",
                  "body": "body",
                  "channel": "channel",
                  "status": "new",
                  "assignedUserId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt",
                  "closedAt": "closedAt"
                },
                {
                  "id": "x",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "contactName": "contactName",
                  "contactEmail": "contactEmail",
                  "contactPhone": "contactPhone",
                  "subject": "subject",
                  "body": "body",
                  "channel": "channel",
                  "status": "new",
                  "assignedUserId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt",
                  "closedAt": "closedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/list")
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

        var response = await Client.Partners.PostV1PartnersInquiriesListAsync(
            new PostV1PartnersInquiriesListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
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
                  "partnerName": "partnerName",
                  "contactName": "contactName",
                  "contactEmail": "contactEmail",
                  "contactPhone": "contactPhone",
                  "subject": "subject",
                  "body": "body",
                  "channel": "channel",
                  "status": "new",
                  "assignedUserId": "assignedUserId",
                  "notes": "notes",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt",
                  "closedAt": "closedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/list")
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

        var response = await Client.Partners.PostV1PartnersInquiriesListAsync(
            new PostV1PartnersInquiriesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
