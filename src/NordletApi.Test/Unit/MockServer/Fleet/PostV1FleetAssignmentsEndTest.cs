using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Fleet;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1FleetAssignmentsEndTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "toDate": "toDate"
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
                    .WithPath("/v1/fleet/assignments/end")
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

        var response = await Client.Fleet.PostV1FleetAssignmentsEndAsync(
            new PostV1FleetAssignmentsEndRequest { Id = "x", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "toDate": "toDate"
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
                    .WithPath("/v1/fleet/assignments/end")
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

        var response = await Client.Fleet.PostV1FleetAssignmentsEndAsync(
            new PostV1FleetAssignmentsEndRequest { Id = "id", ToDate = "toDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
