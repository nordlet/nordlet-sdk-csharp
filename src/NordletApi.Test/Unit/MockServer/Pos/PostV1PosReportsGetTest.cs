using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Pos;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PosReportsGetTest : BaseMockServerTest
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
              "createdAt": "createdAt",
              "vatLines": [
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                },
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/reports/get")
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

        var response = await Client.Pos.PostV1PosReportsGetAsync(
            new PostV1PosReportsGetRequest { Id = "x" }
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
              "createdAt": "createdAt",
              "vatLines": [
                {
                  "vatRatePercent": "vatRatePercent",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/pos/reports/get")
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

        var response = await Client.Pos.PostV1PosReportsGetAsync(
            new PostV1PosReportsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
