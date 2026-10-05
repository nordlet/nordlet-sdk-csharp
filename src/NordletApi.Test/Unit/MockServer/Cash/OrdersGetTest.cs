using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Cash;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OrdersGetTest : BaseMockServerTest
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
              "type": "receipt",
              "series": "series",
              "number": 1000000,
              "fullNumber": "fullNumber",
              "date": "2023-01-15",
              "partnerId": "x",
              "employeeId": "x",
              "amount": "amount",
              "currency": "currency",
              "purpose": "purpose",
              "cashAccountCode": "cashAccountCode",
              "counterAccountCode": "counterAccountCode",
              "journalTransactionId": "x",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/cash/orders/get")
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

        var response = await Client.Cash.OrdersGetAsync(new OrdersGetCashRequest { Id = "x" });
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
              "type": "receipt",
              "series": "series",
              "number": 1000000,
              "fullNumber": "fullNumber",
              "date": "2026-07-01",
              "partnerId": "partnerId",
              "employeeId": "employeeId",
              "amount": "amount",
              "currency": "currency",
              "purpose": "purpose",
              "cashAccountCode": "cashAccountCode",
              "counterAccountCode": "counterAccountCode",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/cash/orders/get")
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

        var response = await Client.Cash.OrdersGetAsync(new OrdersGetCashRequest { Id = "id" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}
