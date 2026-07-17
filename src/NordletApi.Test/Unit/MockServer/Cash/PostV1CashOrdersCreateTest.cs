using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Cash;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1CashOrdersCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "type": "receipt",
              "date": "date",
              "amount": "amount",
              "purpose": "x",
              "counterAccountCode": "x"
            }
            """;

        const string mockResponse = """
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

        var response = await Client.Cash.PostV1CashOrdersCreateAsync(
            new PostV1CashOrdersCreateRequest
            {
                Type = PostV1CashOrdersCreateRequestType.Receipt,
                Date = "date",
                Amount = "amount",
                Purpose = "x",
                CounterAccountCode = "x",
                CashAccountCode = null,
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
              "date": "date",
              "amount": "amount",
              "purpose": "purpose",
              "counterAccountCode": "counterAccountCode"
            }
            """;

        const string mockResponse = """
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

        var response = await Client.Cash.PostV1CashOrdersCreateAsync(
            new PostV1CashOrdersCreateRequest
            {
                Type = PostV1CashOrdersCreateRequestType.Receipt,
                Date = "date",
                Amount = "amount",
                Purpose = "purpose",
                CounterAccountCode = "counterAccountCode",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
