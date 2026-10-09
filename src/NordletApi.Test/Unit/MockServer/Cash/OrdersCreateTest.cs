using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Cash;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class OrdersCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "type": "receipt",
              "date": "2023-01-15",
              "amount": "amount",
              "purpose": "x"
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
              "saleInvoiceId": "x",
              "purchaseInvoiceId": "x",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/cash/orders/create")
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

        var response = await Client.Cash.OrdersCreateAsync(
            new OrdersCreateCashRequest
            {
                Type = OrdersCreateCashRequestType.Receipt,
                Date = new DateOnly(2023, 1, 15),
                Amount = "amount",
                Purpose = "x",
                CounterAccountCode = null,
                CashAccountCode = null,
                SaleInvoiceId = null,
                PurchaseInvoiceId = null,
                Series = null,
                PartnerId = null,
                EmployeeId = null,
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
              "type": "receipt",
              "date": "2026-07-01",
              "amount": "121.0000",
              "purpose": "purpose"
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
              "saleInvoiceId": "saleInvoiceId",
              "purchaseInvoiceId": "purchaseInvoiceId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/cash/orders/create")
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

        var response = await Client.Cash.OrdersCreateAsync(
            new OrdersCreateCashRequest
            {
                Type = OrdersCreateCashRequestType.Receipt,
                Date = new DateOnly(2026, 7, 1),
                Amount = "121.0000",
                Purpose = "purpose",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
