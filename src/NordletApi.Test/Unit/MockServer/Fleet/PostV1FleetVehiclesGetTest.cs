using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Fleet;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1FleetVehiclesGetTest : BaseMockServerTest
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
              "plateNumber": "plateNumber",
              "make": "make",
              "model": "model",
              "year": 1000000,
              "vin": "vin",
              "fuelType": "fuelType",
              "acquisitionDate": "acquisitionDate",
              "marketValue": "marketValue",
              "fixedAssetId": "x",
              "technicalInspectionDue": "technicalInspectionDue",
              "insuranceDue": "insuranceDue",
              "status": "active",
              "notes": "notes",
              "currentAssignment": {
                "id": "x",
                "employeeId": "x",
                "employeeName": "employeeName",
                "fromDate": "fromDate",
                "privateUse": true,
                "employerPaysFuel": true
              },
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/vehicles/get")
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

        var response = await Client.Fleet.PostV1FleetVehiclesGetAsync(
            new PostV1FleetVehiclesGetRequest { Id = "x" }
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
              "plateNumber": "plateNumber",
              "make": "make",
              "model": "model",
              "year": 1000000,
              "vin": "vin",
              "fuelType": "fuelType",
              "acquisitionDate": "acquisitionDate",
              "marketValue": "marketValue",
              "fixedAssetId": "fixedAssetId",
              "technicalInspectionDue": "technicalInspectionDue",
              "insuranceDue": "insuranceDue",
              "status": "active",
              "notes": "notes",
              "currentAssignment": {
                "id": "id",
                "employeeId": "employeeId",
                "employeeName": "employeeName",
                "fromDate": "fromDate",
                "privateUse": true,
                "employerPaysFuel": true
              },
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/vehicles/get")
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

        var response = await Client.Fleet.PostV1FleetVehiclesGetAsync(
            new PostV1FleetVehiclesGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
