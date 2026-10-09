using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Cash;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ExpenseReportsGetTest : BaseMockServerTest
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
              "number": "number",
              "employeeId": "x",
              "date": "2023-01-15",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "total": "total",
              "journalTransactionId": "x",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "lines": [
                {
                  "id": "x",
                  "description": "description",
                  "documentNumber": "documentNumber",
                  "accountCode": "accountCode",
                  "netAmount": "netAmount",
                  "vatAmount": "vatAmount"
                },
                {
                  "id": "x",
                  "description": "description",
                  "documentNumber": "documentNumber",
                  "accountCode": "accountCode",
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
                    .WithPath("/v1/cash/expense-reports/get")
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

        var response = await Client.Cash.ExpenseReportsGetAsync(
            new ExpenseReportsGetCashRequest { Id = "x" }
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
              "number": "number",
              "employeeId": "employeeId",
              "date": "2026-07-01",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "total": "total",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "lines": [
                {
                  "id": "id",
                  "description": "description",
                  "documentNumber": "documentNumber",
                  "accountCode": "accountCode",
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
                    .WithPath("/v1/cash/expense-reports/get")
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

        var response = await Client.Cash.ExpenseReportsGetAsync(
            new ExpenseReportsGetCashRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
