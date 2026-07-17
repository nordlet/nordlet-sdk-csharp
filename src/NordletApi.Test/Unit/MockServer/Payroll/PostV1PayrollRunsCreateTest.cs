using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PayrollRunsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "year": 1000000,
              "month": 1000000,
              "status": "draft",
              "grossTotal": "grossTotal",
              "npdTotal": "npdTotal",
              "gpmTotal": "gpmTotal",
              "sodraEmployeeTotal": "sodraEmployeeTotal",
              "sodraEmployerTotal": "sodraEmployerTotal",
              "netTotal": "netTotal",
              "journalTransactionId": "x",
              "notes": "notes",
              "createdAt": "createdAt",
              "approvedAt": "approvedAt",
              "lines": [
                {
                  "id": "x",
                  "employeeId": "x",
                  "contractId": "x",
                  "employeeName": "employeeName",
                  "gross": "gross",
                  "additions": [
                    {
                      "name": "name",
                      "amount": "amount",
                      "taxable": true
                    },
                    {
                      "name": "name",
                      "amount": "amount",
                      "taxable": true
                    }
                  ],
                  "deductions": [
                    {
                      "name": "name",
                      "amount": "amount"
                    },
                    {
                      "name": "name",
                      "amount": "amount"
                    }
                  ],
                  "taxableBase": "taxableBase",
                  "npd": "npd",
                  "gpm": "gpm",
                  "sodraEmployee": "sodraEmployee",
                  "sodraEmployer": "sodraEmployer",
                  "net": "net"
                },
                {
                  "id": "x",
                  "employeeId": "x",
                  "contractId": "x",
                  "employeeName": "employeeName",
                  "gross": "gross",
                  "additions": [
                    {
                      "name": "name",
                      "amount": "amount",
                      "taxable": true
                    },
                    {
                      "name": "name",
                      "amount": "amount",
                      "taxable": true
                    }
                  ],
                  "deductions": [
                    {
                      "name": "name",
                      "amount": "amount"
                    },
                    {
                      "name": "name",
                      "amount": "amount"
                    }
                  ],
                  "taxableBase": "taxableBase",
                  "npd": "npd",
                  "gpm": "gpm",
                  "sodraEmployee": "sodraEmployee",
                  "sodraEmployer": "sodraEmployer",
                  "net": "net"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/create")
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

        var response = await Client.Payroll.PostV1PayrollRunsCreateAsync(
            new PostV1PayrollRunsCreateRequest
            {
                Year = 1000000,
                Month = 1000000,
                Lines = null,
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
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "year": 1000000,
              "month": 1000000,
              "status": "draft",
              "grossTotal": "grossTotal",
              "npdTotal": "npdTotal",
              "gpmTotal": "gpmTotal",
              "sodraEmployeeTotal": "sodraEmployeeTotal",
              "sodraEmployerTotal": "sodraEmployerTotal",
              "netTotal": "netTotal",
              "journalTransactionId": "journalTransactionId",
              "notes": "notes",
              "createdAt": "createdAt",
              "approvedAt": "approvedAt",
              "lines": [
                {
                  "id": "id",
                  "employeeId": "employeeId",
                  "contractId": "contractId",
                  "employeeName": "employeeName",
                  "gross": "gross",
                  "additions": [
                    {
                      "name": "name",
                      "amount": "amount",
                      "taxable": true
                    }
                  ],
                  "deductions": [
                    {
                      "name": "name",
                      "amount": "amount"
                    }
                  ],
                  "taxableBase": "taxableBase",
                  "npd": "npd",
                  "gpm": "gpm",
                  "sodraEmployee": "sodraEmployee",
                  "sodraEmployer": "sodraEmployer",
                  "net": "net"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/runs/create")
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

        var response = await Client.Payroll.PostV1PayrollRunsCreateAsync(
            new PostV1PayrollRunsCreateRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
