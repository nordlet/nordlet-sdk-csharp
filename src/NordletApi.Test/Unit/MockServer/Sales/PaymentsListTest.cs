using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PaymentsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "from": "2023-01-15",
              "to": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "x",
                  "date": "2023-01-15",
                  "invoiceId": "x",
                  "fullNumber": "fullNumber",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "amount": "amount",
                  "currency": "currency",
                  "method": "bank_transfer"
                },
                {
                  "id": "x",
                  "date": "2023-01-15",
                  "invoiceId": "x",
                  "fullNumber": "fullNumber",
                  "partnerId": "x",
                  "partnerName": "partnerName",
                  "amount": "amount",
                  "currency": "currency",
                  "method": "bank_transfer"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totalsByCurrency": {
                "totalsByCurrency": "totalsByCurrency"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/payments/list")
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

        var response = await Client.Sales.PaymentsListAsync(
            new PaymentsListSalesRequest
            {
                From = new DateOnly(2023, 1, 15),
                To = new DateOnly(2023, 1, 15),
                Page = null,
                PageSize = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "from": "2026-07-01",
              "to": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "id",
                  "date": "2026-07-01",
                  "invoiceId": "invoiceId",
                  "fullNumber": "fullNumber",
                  "partnerId": "partnerId",
                  "partnerName": "partnerName",
                  "amount": "amount",
                  "currency": "currency",
                  "method": "bank_transfer"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totalsByCurrency": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/payments/list")
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

        var response = await Client.Sales.PaymentsListAsync(
            new PaymentsListSalesRequest
            {
                From = new DateOnly(2026, 7, 1),
                To = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
