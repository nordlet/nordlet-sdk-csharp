using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class BlankAnEmployeesPersonalDataAndHideTheRecordTest : BaseMockServerTest
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
                    .WithPath("/v1/hr/employees/anonymize")
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

        var response = await Client.Hr.BlankAnEmployeesPersonalDataAndHideTheRecordAsync(
            new PostV1HrEmployeesAnonymizeRequest { Id = "x" }
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
                    .WithPath("/v1/hr/employees/anonymize")
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

        var response = await Client.Hr.BlankAnEmployeesPersonalDataAndHideTheRecordAsync(
            new PostV1HrEmployeesAnonymizeRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
