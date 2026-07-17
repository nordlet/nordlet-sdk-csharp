using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrEmployeesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "firstName": "x",
              "lastName": "x"
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
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/create")
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

        var response = await Client.Hr.PostV1HrEmployeesCreateAsync(
            new PostV1HrEmployeesCreateRequest
            {
                Code = null,
                FirstName = "x",
                LastName = "x",
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
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "firstName": "firstName",
              "lastName": "lastName"
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
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/create")
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

        var response = await Client.Hr.PostV1HrEmployeesCreateAsync(
            new PostV1HrEmployeesCreateRequest { FirstName = "firstName", LastName = "lastName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
