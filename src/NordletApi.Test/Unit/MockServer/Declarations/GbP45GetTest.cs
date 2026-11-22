using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbP45GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId"
            }
            """;

        const string mockResponse = """
            {
              "taxYear": 1.1,
              "completedOn": "completedOn",
              "employer": {
                "officeNumber": "officeNumber",
                "reference": "reference",
                "name": "name",
                "address": [
                  "address",
                  "address"
                ],
                "postcode": "postcode"
              },
              "employee": {
                "nino": "nino",
                "surname": "surname",
                "firstNames": "firstNames",
                "leavingDate": "2023-01-15",
                "payrollNumber": "payrollNumber",
                "gender": "M",
                "dateOfBirth": "dateOfBirth",
                "address": [
                  "address",
                  "address"
                ],
                "postcode": "postcode"
              },
              "studentLoanDeductionsToContinue": true,
              "taxCode": "taxCode",
              "week1Month1": true,
              "lastEntries": {
                "weekNumber": 1.1,
                "monthNumber": 1.1,
                "totalPayToDate": "2023-01-15",
                "totalTaxToDate": "2023-01-15"
              },
              "thisEmployment": {
                "totalPay": "totalPay",
                "totalTax": "totalTax"
              },
              "warnings": [
                "warnings",
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/p45/get")
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

        var response = await Client.Declarations.GbP45GetAsync(
            new GbP45GetDeclarationsRequest { EmployeeId = "employeeId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId"
            }
            """;

        const string mockResponse = """
            {
              "taxYear": 1.1,
              "completedOn": "completedOn",
              "employer": {
                "officeNumber": "officeNumber",
                "reference": "reference",
                "name": "name",
                "address": [
                  "address"
                ],
                "postcode": "postcode"
              },
              "employee": {
                "nino": "nino",
                "surname": "surname",
                "firstNames": "firstNames",
                "leavingDate": "2026-07-01",
                "payrollNumber": "payrollNumber",
                "gender": "M",
                "dateOfBirth": "dateOfBirth",
                "address": [
                  "address"
                ],
                "postcode": "postcode"
              },
              "studentLoanDeductionsToContinue": true,
              "taxCode": "taxCode",
              "week1Month1": true,
              "lastEntries": {
                "weekNumber": 1.1,
                "monthNumber": 1.1,
                "totalPayToDate": "2026-07-01",
                "totalTaxToDate": "2026-07-01"
              },
              "thisEmployment": {
                "totalPay": "totalPay",
                "totalTax": "totalTax"
              },
              "warnings": [
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/p45/get")
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

        var response = await Client.Declarations.GbP45GetAsync(
            new GbP45GetDeclarationsRequest { EmployeeId = "employeeId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
