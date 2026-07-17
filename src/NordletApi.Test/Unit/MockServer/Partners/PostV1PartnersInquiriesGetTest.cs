using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersInquiriesGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/get")
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

        var response = await Client.Partners.PostV1PartnersInquiriesGetAsync(
            new PostV1PartnersInquiriesGetRequest { Id = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/get")
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

        var response = await Client.Partners.PostV1PartnersInquiriesGetAsync(
            new PostV1PartnersInquiriesGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
