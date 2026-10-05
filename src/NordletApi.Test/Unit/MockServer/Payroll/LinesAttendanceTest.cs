using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LinesAttendanceTest : BaseMockServerTest
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
              "employeeId": "x",
              "contractId": "x",
              "employeeName": "employeeName",
              "gross": "gross",
              "natura": "natura",
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
              "taxAllowance": "taxAllowance",
              "incomeTax": "incomeTax",
              "employeeContributions": "employeeContributions",
              "employerContributions": "employerContributions",
              "components": [
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                },
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                }
              ],
              "net": "net",
              "daysWorked": "daysWorked",
              "hoursWorked": "hoursWorked",
              "registeredDays": "registeredDays",
              "averageHourlyEarnings": "averageHourlyEarnings"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/lines/attendance")
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

        var response = await Client.Payroll.LinesAttendanceAsync(
            new LinesAttendancePayrollRequest
            {
                Id = "x",
                DaysWorked = null,
                HoursWorked = null,
                RegisteredDays = null,
                AverageHourlyEarnings = null,
            }
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
              "employeeId": "employeeId",
              "contractId": "contractId",
              "employeeName": "employeeName",
              "gross": "gross",
              "natura": "natura",
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
              "taxAllowance": "taxAllowance",
              "incomeTax": "incomeTax",
              "employeeContributions": "employeeContributions",
              "employerContributions": "employerContributions",
              "components": [
                {
                  "code": "code",
                  "kind": "allowance",
                  "amount": "amount",
                  "rate": "rate",
                  "base": "base"
                }
              ],
              "net": "net",
              "daysWorked": "daysWorked",
              "hoursWorked": "hoursWorked",
              "registeredDays": "registeredDays",
              "averageHourlyEarnings": "averageHourlyEarnings"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/lines/attendance")
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

        var response = await Client.Payroll.LinesAttendanceAsync(
            new LinesAttendancePayrollRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
