using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Transport;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1TransportWaybillsCancelTest : BaseMockServerTest
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
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/transport/waybills/cancel")
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

        var response = await Client.Transport.PostV1TransportWaybillsCancelAsync(
            new PostV1TransportWaybillsCancelRequest { Id = "x" }
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
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/transport/waybills/cancel")
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

        var response = await Client.Transport.PostV1TransportWaybillsCancelAsync(
            new PostV1TransportWaybillsCancelRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
