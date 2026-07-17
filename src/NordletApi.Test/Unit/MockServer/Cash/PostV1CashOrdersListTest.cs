using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Cash;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CashOrdersListTest : BaseMockServerTest
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
                  "type": "receipt",
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "date": "date",
                  "partnerId": "x",
                  "employeeId": "x",
                  "amount": "amount",
                  "currency": "currency",
                  "purpose": "purpose",
                  "cashAccountCode": "cashAccountCode",
                  "counterAccountCode": "counterAccountCode",
                  "journalTransactionId": "x",
                  "notes": "notes",
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "type": "receipt",
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "date": "date",
                  "partnerId": "x",
                  "employeeId": "x",
                  "amount": "amount",
                  "currency": "currency",
                  "purpose": "purpose",
                  "cashAccountCode": "cashAccountCode",
                  "counterAccountCode": "counterAccountCode",
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
                    .WithPath("/v1/cash/orders/list")
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

        var response = await Client.Cash.PostV1CashOrdersListAsync(
            new PostV1CashOrdersListRequest
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
                  "type": "receipt",
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "date": "date",
                  "partnerId": "partnerId",
                  "employeeId": "employeeId",
                  "amount": "amount",
                  "currency": "currency",
                  "purpose": "purpose",
                  "cashAccountCode": "cashAccountCode",
                  "counterAccountCode": "counterAccountCode",
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
                    .WithPath("/v1/cash/orders/list")
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

        var response = await Client.Cash.PostV1CashOrdersListAsync(
            new PostV1CashOrdersListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
