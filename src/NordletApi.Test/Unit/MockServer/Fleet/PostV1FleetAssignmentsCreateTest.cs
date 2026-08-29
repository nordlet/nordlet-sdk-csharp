using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Fleet;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1FleetAssignmentsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "vehicleId": "x",
              "employeeId": "x",
              "fromDate": "fromDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "vehicleId": "x",
              "plateNumber": "plateNumber",
              "employeeId": "x",
              "employeeName": "employeeName",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "privateUse": true,
              "employerPaysFuel": true,
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assignments/create")
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

        var response = await Client.Fleet.PostV1FleetAssignmentsCreateAsync(
            new PostV1FleetAssignmentsCreateRequest
            {
                VehicleId = "x",
                EmployeeId = "x",
                FromDate = "fromDate",
                ToDate = null,
                PrivateUse = null,
                EmployerPaysFuel = null,
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
              "vehicleId": "vehicleId",
              "employeeId": "employeeId",
              "fromDate": "fromDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "vehicleId": "vehicleId",
              "plateNumber": "plateNumber",
              "employeeId": "employeeId",
              "employeeName": "employeeName",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "privateUse": true,
              "employerPaysFuel": true,
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assignments/create")
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

        var response = await Client.Fleet.PostV1FleetAssignmentsCreateAsync(
            new PostV1FleetAssignmentsCreateRequest
            {
                VehicleId = "vehicleId",
                EmployeeId = "employeeId",
                FromDate = "fromDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
