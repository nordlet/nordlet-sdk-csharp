using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PosReportsListTest : BaseMockServerTest
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
                  "reportNumber": "reportNumber",
                  "date": "date",
                  "deviceId": "x",
                  "warehouseId": "x",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "cashAmount": "cashAmount",
                  "cardAmount": "cardAmount",
                  "cogsTotal": "cogsTotal",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "reportNumber": "reportNumber",
                  "date": "date",
                  "deviceId": "x",
                  "warehouseId": "x",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "cashAmount": "cashAmount",
                  "cardAmount": "cardAmount",
                  "cogsTotal": "cogsTotal",
                  "journalTransactionId": "x",
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
                    .WithPath("/v1/pos/reports/list")
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

        var response = await Client.Pos.PostV1PosReportsListAsync(
            new PostV1PosReportsListRequest
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
                  "reportNumber": "reportNumber",
                  "date": "date",
                  "deviceId": "deviceId",
                  "warehouseId": "warehouseId",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "cashAmount": "cashAmount",
                  "cardAmount": "cardAmount",
                  "cogsTotal": "cogsTotal",
                  "journalTransactionId": "journalTransactionId",
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
                    .WithPath("/v1/pos/reports/list")
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

        var response = await Client.Pos.PostV1PosReportsListAsync(
            new PostV1PosReportsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
