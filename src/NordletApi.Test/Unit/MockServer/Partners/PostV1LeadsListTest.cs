using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1LeadsListTest : BaseMockServerTest
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
                },
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
                    .WithPath("/v1/leads/list")
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

        var response = await Client.Partners.PostV1LeadsListAsync(
            new PostV1LeadsListRequest
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
                    .WithPath("/v1/leads/list")
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

        var response = await Client.Partners.PostV1LeadsListAsync(new PostV1LeadsListRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
