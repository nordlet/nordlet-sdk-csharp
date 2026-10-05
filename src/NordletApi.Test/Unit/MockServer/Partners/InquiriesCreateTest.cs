using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InquiriesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "subject": "x"
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
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z",
              "closedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/create")
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

        var response = await Client.Partners.InquiriesCreateAsync(
            new InquiriesCreatePartnersRequest
            {
                PartnerId = null,
                ContactName = null,
                ContactEmail = null,
                ContactPhone = null,
                Subject = "x",
                Body = null,
                Channel = null,
                AssignedUserId = null,
                Notes = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "subject": "subject"
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
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z",
              "closedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/create")
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

        var response = await Client.Partners.InquiriesCreateAsync(
            new InquiriesCreatePartnersRequest { Subject = "subject" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
