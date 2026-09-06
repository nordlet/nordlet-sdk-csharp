using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrEmployeesUpdateTest : BaseMockServerTest
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
              "birthDate": "birthDate",
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
              "hireDate": "hireDate",
              "terminationDate": "terminationDate",
              "applyNpd": true,
              "npdOverride": "npdOverride",
              "pensionAccumulation": true,
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
              "createdAt": "createdAt"
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

        var response = await Client.Hr.PostV1HrEmployeesUpdateAsync(
            new PostV1HrEmployeesUpdateRequest
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
                ApplyNpd = null,
                NpdOverride = null,
                PensionAccumulation = null,
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
              "birthDate": "birthDate",
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
              "hireDate": "hireDate",
              "terminationDate": "terminationDate",
              "applyNpd": true,
              "npdOverride": "npdOverride",
              "pensionAccumulation": true,
              "status": "active",
              "notes": "notes",
              "attributes": [
                {
                  "name": "name",
                  "value": "value"
                }
              ],
              "createdAt": "createdAt"
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

        var response = await Client.Hr.PostV1HrEmployeesUpdateAsync(
            new PostV1HrEmployeesUpdateRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
