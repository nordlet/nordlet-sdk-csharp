using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AgreementsAgreementsListTest : BaseMockServerTest
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
                  "typeId": "x",
                  "partnerId": "x",
                  "number": "number",
                  "name": "name",
                  "startDate": "startDate",
                  "endDate": "endDate",
                  "autoRenew": true,
                  "value": "value",
                  "currency": "currency",
                  "status": "draft",
                  "notes": "notes",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "typeId": "x",
                  "partnerId": "x",
                  "number": "number",
                  "name": "name",
                  "startDate": "startDate",
                  "endDate": "endDate",
                  "autoRenew": true,
                  "value": "value",
                  "currency": "currency",
                  "status": "draft",
                  "notes": "notes",
                  "createdAt": "createdAt"
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
                    .WithPath("/v1/agreements/agreements/list")
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

        var response = await Client.Agreements.PostV1AgreementsAgreementsListAsync(
            new PostV1AgreementsAgreementsListRequest
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
                  "typeId": "typeId",
                  "partnerId": "partnerId",
                  "number": "number",
                  "name": "name",
                  "startDate": "startDate",
                  "endDate": "endDate",
                  "autoRenew": true,
                  "value": "value",
                  "currency": "currency",
                  "status": "draft",
                  "notes": "notes",
                  "createdAt": "createdAt"
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
                    .WithPath("/v1/agreements/agreements/list")
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

        var response = await Client.Agreements.PostV1AgreementsAgreementsListAsync(
            new PostV1AgreementsAgreementsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
