using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Cash;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ExpenseReportsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "date": "2023-01-15",
              "lines": [
                {
                  "description": "x",
                  "accountCode": "x",
                  "netAmount": "netAmount"
                },
                {
                  "description": "x",
                  "accountCode": "x",
                  "netAmount": "netAmount"
                }
              ]
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
                    .WithPath("/v1/cash/expense-reports/create")
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

        var response = await Client.Cash.ExpenseReportsCreateAsync(
            new ExpenseReportsCreateCashRequest
            {
                EmployeeId = "x",
                Date = new DateOnly(2023, 1, 15),
                Notes = null,
                Lines = new List<ExpenseReportsCreateCashRequestLinesItem>()
                {
                    new ExpenseReportsCreateCashRequestLinesItem
                    {
                        Description = "x",
                        DocumentNumber = null,
                        AccountCode = "x",
                        NetAmount = "netAmount",
                        VatAmount = null,
                    },
                    new ExpenseReportsCreateCashRequestLinesItem
                    {
                        Description = "x",
                        DocumentNumber = null,
                        AccountCode = "x",
                        NetAmount = "netAmount",
                        VatAmount = null,
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId",
              "date": "2026-07-01",
              "lines": [
                {
                  "description": "description",
                  "accountCode": "accountCode",
                  "netAmount": "121.00"
                }
              ]
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
                    .WithPath("/v1/cash/expense-reports/create")
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

        var response = await Client.Cash.ExpenseReportsCreateAsync(
            new ExpenseReportsCreateCashRequest
            {
                EmployeeId = "employeeId",
                Date = new DateOnly(2026, 7, 1),
                Lines = new List<ExpenseReportsCreateCashRequestLinesItem>()
                {
                    new ExpenseReportsCreateCashRequestLinesItem
                    {
                        Description = "description",
                        AccountCode = "accountCode",
                        NetAmount = "121.00",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
