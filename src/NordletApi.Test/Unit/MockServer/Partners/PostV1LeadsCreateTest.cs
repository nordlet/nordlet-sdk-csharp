using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LeadsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x"
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
              "convertedAt": "convertedAt",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/leads/create")
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

        var response = await Client.Partners.PostV1LeadsCreateAsync(
            new PostV1LeadsCreateRequest
            {
                Name = "x",
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
              "name": "name"
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
              "convertedAt": "convertedAt",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/leads/create")
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

        var response = await Client.Partners.PostV1LeadsCreateAsync(
            new PostV1LeadsCreateRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
