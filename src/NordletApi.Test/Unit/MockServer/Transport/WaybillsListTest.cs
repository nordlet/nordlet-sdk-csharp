using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Transport;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class WaybillsListTest : BaseMockServerTest
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
                  "consigneeName": "consigneeName"
                },
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
                  "consigneeName": "consigneeName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              },
              "totalsByCurrency": {
                "totalsByCurrency": {
                  "totalsByCurrency": "totalsByCurrency"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/transport/waybills/list")
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

        var response = await Client.Transport.WaybillsListAsync(
            new WaybillsListTransportRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
                Totals = null,
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
                  "consigneeName": "consigneeName"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              },
              "totalsByCurrency": {
                "key": {
                  "key": "value"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/transport/waybills/list")
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

        var response = await Client.Transport.WaybillsListAsync(new WaybillsListTransportRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
