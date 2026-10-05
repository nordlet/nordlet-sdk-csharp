using global::System.Globalization;
using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Transport;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class WaybillsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "consigneePartnerId": "x",
              "dispatchAt": "2024-01-15T09:30:00.000Z",
              "loadAddress": "x",
              "unloadAddress": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "status": "draft",
              "series": "series",
              "fullNumber": "fullNumber",
              "documentDate": "2023-01-15",
              "dispatchAt": "2024-01-15T09:30:00.000Z",
              "estimatedArrivalAt": "2024-01-15T09:30:00.000Z",
              "consigneePartnerId": "x",
              "transporterPartnerId": "x",
              "vehiclePlate": "vehiclePlate",
              "trailerPlate": "trailerPlate",
              "driverName": "driverName",
              "driverSurname": "driverSurname",
              "loadWarehouseId": "x",
              "loadAddress": "loadAddress",
              "unloadAddress": "unloadAddress",
              "valueEur": "valueEur",
              "saleInvoiceId": "x",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z",
              "updatedAt": "2024-01-15T09:30:00.000Z",
              "lines": [
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "productCode": "productCode",
                  "sortOrder": 1000000
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "productCode": "productCode",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/transport/waybills/create")
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

        var response = await Client.Transport.WaybillsCreateAsync(
            new WaybillsCreateTransportRequest
            {
                ConsigneePartnerId = "x",
                TransporterPartnerId = null,
                DocumentDate = null,
                DispatchAt = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                EstimatedArrivalAt = null,
                VehiclePlate = null,
                TrailerPlate = null,
                DriverName = null,
                DriverSurname = null,
                LoadWarehouseId = null,
                LoadAddress = "x",
                UnloadAddress = "x",
                ValueEur = null,
                SaleInvoiceId = null,
                Notes = null,
                Series = null,
                Lines = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "consigneePartnerId": "consigneePartnerId",
              "dispatchAt": "2024-01-15T09:30:00.000Z",
              "loadAddress": "loadAddress",
              "unloadAddress": "unloadAddress"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "status": "draft",
              "series": "series",
              "fullNumber": "fullNumber",
              "documentDate": "2026-07-01",
              "dispatchAt": "2026-07-01T09:30:00.000Z",
              "estimatedArrivalAt": "2026-07-01T09:30:00.000Z",
              "consigneePartnerId": "consigneePartnerId",
              "transporterPartnerId": "transporterPartnerId",
              "vehiclePlate": "vehiclePlate",
              "trailerPlate": "trailerPlate",
              "driverName": "driverName",
              "driverSurname": "driverSurname",
              "loadWarehouseId": "loadWarehouseId",
              "loadAddress": "loadAddress",
              "unloadAddress": "unloadAddress",
              "valueEur": "valueEur",
              "saleInvoiceId": "saleInvoiceId",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z",
              "updatedAt": "2026-07-01T09:30:00.000Z",
              "lines": [
                {
                  "id": "id",
                  "itemId": "itemId",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "productCode": "productCode",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/transport/waybills/create")
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

        var response = await Client.Transport.WaybillsCreateAsync(
            new WaybillsCreateTransportRequest
            {
                ConsigneePartnerId = "consigneePartnerId",
                DispatchAt = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
                LoadAddress = "loadAddress",
                UnloadAddress = "unloadAddress",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
