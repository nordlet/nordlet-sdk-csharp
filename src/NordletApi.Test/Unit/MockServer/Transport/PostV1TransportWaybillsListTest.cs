using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Transport;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1TransportWaybillsListTest : BaseMockServerTest
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
                  "documentDate": "documentDate",
                  "dispatchAt": "dispatchAt",
                  "estimatedArrivalAt": "estimatedArrivalAt",
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
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "status": "draft",
                  "series": "series",
                  "fullNumber": "fullNumber",
                  "documentDate": "documentDate",
                  "dispatchAt": "dispatchAt",
                  "estimatedArrivalAt": "estimatedArrivalAt",
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
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
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

        var response = await Client.Transport.PostV1TransportWaybillsListAsync(
            new PostV1TransportWaybillsListRequest
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
                  "status": "draft",
                  "series": "series",
                  "fullNumber": "fullNumber",
                  "documentDate": "documentDate",
                  "dispatchAt": "dispatchAt",
                  "estimatedArrivalAt": "estimatedArrivalAt",
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
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
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

        var response = await Client.Transport.PostV1TransportWaybillsListAsync(
            new PostV1TransportWaybillsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
