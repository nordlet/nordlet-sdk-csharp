using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InquiriesUpdateTest : BaseMockServerTest
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
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z",
              "closedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/update")
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

        var response = await Client.Partners.InquiriesUpdateAsync(
            new InquiriesUpdatePartnersRequest
            {
                Id = "x",
                PartnerId = null,
                Subject = null,
                Body = null,
                Channel = null,
                Status = null,
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
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z",
              "closedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/inquiries/update")
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

        var response = await Client.Partners.InquiriesUpdateAsync(
            new InquiriesUpdatePartnersRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
