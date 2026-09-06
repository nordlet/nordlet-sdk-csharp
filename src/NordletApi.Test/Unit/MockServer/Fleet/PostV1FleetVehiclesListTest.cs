using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Fleet;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1FleetVehiclesListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                  "documents": [
                    {
                      "name": "x",
                      "ref": "x"
                    },
                    {
                      "name": "x",
                      "ref": "x"
                    }
                  ],
                  "currentAssignment": {
                    "id": "x",
                    "employeeId": "x",
                    "employeeName": "employeeName",
                    "fromDate": "fromDate",
                    "privateUse": true,
                    "employerPaysFuel": true
                  },
                  "createdAt": "createdAt"
                },
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
                  "documents": [
                    {
                      "name": "x",
                      "ref": "x"
                    },
                    {
                      "name": "x",
                      "ref": "x"
                    }
                  ],
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/vehicles/list")
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

        var response = await Client.Fleet.PostV1FleetVehiclesListAsync(
            new PostV1FleetVehiclesListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                  "documents": [
                    {
                      "name": "name",
                      "ref": "ref"
                    }
                  ],
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/vehicles/list")
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

        var response = await Client.Fleet.PostV1FleetVehiclesListAsync(
            new PostV1FleetVehiclesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
