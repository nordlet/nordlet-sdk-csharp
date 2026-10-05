using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EmployeesUpdateTest : BaseMockServerTest
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
              "code": "code",
              "firstName": "firstName",
              "lastName": "lastName",
              "personalCode": "personalCode",
              "birthDate": "2023-01-15",
              "email": "email",
              "phone": "phone",
              "address": {
                "street": "street",
                "city": "city",
                "postalCode": "postalCode",
                "countryCode": "xy"
              },
              "iban": "iban",
              "socialInsuranceNo": "socialInsuranceNo",
              "socialInsuranceStart": "socialInsuranceStart",
              "hireDate": "2023-01-15",
              "terminationDate": "2023-01-15",
              "applyAllowance": true,
              "allowanceOverride": "allowanceOverride",
              "pensionAccumulation": true,
              "payrollOptions": {
                "payrollOptions": "payrollOptions"
              },
              "status": "active",
              "notes": "notes",
              "attributes": [
                {
                  "name": "x",
                  "value": "value"
                },
                {
                  "name": "x",
                  "value": "value"
                }
              ],
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/update")
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

        var response = await Client.Hr.EmployeesUpdateAsync(
            new EmployeesUpdateHrRequest
            {
                Code = null,
                FirstName = null,
                LastName = null,
                PersonalCode = null,
                BirthDate = null,
                Email = null,
                Phone = null,
                Address = null,
                Iban = null,
                SocialInsuranceNo = null,
                SocialInsuranceStart = null,
                HireDate = null,
                ApplyAllowance = null,
                AllowanceOverride = null,
                PensionAccumulation = null,
                PayrollOptions = null,
                Notes = null,
                Attributes = null,
                Id = "x",
                TerminationDate = null,
                Status = null,
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
              "code": "code",
              "firstName": "firstName",
              "lastName": "lastName",
              "personalCode": "personalCode",
              "birthDate": "2026-07-01",
              "email": "email",
              "phone": "phone",
              "address": {
                "street": "street",
                "city": "city",
                "postalCode": "postalCode",
                "countryCode": "countryCode"
              },
              "iban": "iban",
              "socialInsuranceNo": "socialInsuranceNo",
              "socialInsuranceStart": "socialInsuranceStart",
              "hireDate": "2026-07-01",
              "terminationDate": "2026-07-01",
              "applyAllowance": true,
              "allowanceOverride": "allowanceOverride",
              "pensionAccumulation": true,
              "payrollOptions": {
                "key": "value"
              },
              "status": "active",
              "notes": "notes",
              "attributes": [
                {
                  "name": "name",
                  "value": "value"
                }
              ],
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/update")
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

        var response = await Client.Hr.EmployeesUpdateAsync(
            new EmployeesUpdateHrRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
