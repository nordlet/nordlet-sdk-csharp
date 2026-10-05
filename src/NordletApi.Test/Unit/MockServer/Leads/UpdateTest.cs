using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Leads;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
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
              "name": "name",
              "contactName": "contactName",
              "email": "email",
              "phone": "phone",
              "website": "website",
              "countryCode": "countryCode",
              "sourceId": "x",
              "sourceName": "sourceName",
              "status": "new",
              "estimatedValue": "estimatedValue",
              "currency": "currency",
              "description": "description",
              "assignedUserId": "x",
              "partnerId": "x",
              "convertedAt": "2024-01-15T09:30:00.000Z",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/leads/update")
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

        var response = await Client.Leads.UpdateAsync(
            new UpdateLeadsRequest
            {
                Id = "x",
                Name = null,
                ContactName = null,
                Email = null,
                Phone = null,
                Website = null,
                CountryCode = null,
                SourceId = null,
                Status = null,
                EstimatedValue = null,
                Currency = null,
                Description = null,
                AssignedUserId = null,
                Documents = null,
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
              "name": "name",
              "contactName": "contactName",
              "email": "email",
              "phone": "phone",
              "website": "website",
              "countryCode": "countryCode",
              "sourceId": "sourceId",
              "sourceName": "sourceName",
              "status": "new",
              "estimatedValue": "estimatedValue",
              "currency": "currency",
              "description": "description",
              "assignedUserId": "assignedUserId",
              "partnerId": "partnerId",
              "convertedAt": "2026-07-01T09:30:00.000Z",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/leads/update")
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

        var response = await Client.Leads.UpdateAsync(new UpdateLeadsRequest { Id = "id" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}
