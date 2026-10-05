using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Fleet;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AssignmentsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "vehicleId": "x",
              "employeeId": "x",
              "fromDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "vehicleId": "x",
              "plateNumber": "plateNumber",
              "employeeId": "x",
              "employeeName": "employeeName",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "privateUse": true,
              "employerPaysFuel": true,
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Fleet.AssignmentsCreateAsync(
            new AssignmentsCreateFleetRequest
            {
                VehicleId = "x",
                EmployeeId = "x",
                FromDate = new DateOnly(2023, 1, 15),
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
              "fromDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "vehicleId": "vehicleId",
              "plateNumber": "plateNumber",
              "employeeId": "employeeId",
              "employeeName": "employeeName",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "privateUse": true,
              "employerPaysFuel": true,
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Fleet.AssignmentsCreateAsync(
            new AssignmentsCreateFleetRequest
            {
                VehicleId = "vehicleId",
                EmployeeId = "employeeId",
                FromDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
