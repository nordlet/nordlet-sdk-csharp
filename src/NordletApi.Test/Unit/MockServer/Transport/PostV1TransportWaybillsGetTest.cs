using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Transport;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1TransportWaybillsGetTest : BaseMockServerTest
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
              "updatedAt": "updatedAt",
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
                    .WithPath("/v1/transport/waybills/get")
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

        var response = await Client.Transport.PostV1TransportWaybillsGetAsync(
            new PostV1TransportWaybillsGetRequest { Id = "x" }
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
              "updatedAt": "updatedAt",
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
                    .WithPath("/v1/transport/waybills/get")
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

        var response = await Client.Transport.PostV1TransportWaybillsGetAsync(
            new PostV1TransportWaybillsGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
