using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesActsCancelTest : BaseMockServerTest
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
              "partnerId": "x",
              "type": "goods",
              "status": "draft",
              "series": "series",
              "fullNumber": "fullNumber",
              "documentDate": "documentDate",
              "saleInvoiceId": "x",
              "transferredByName": "transferredByName",
              "transferredByTitle": "transferredByTitle",
              "acceptedByName": "acceptedByName",
              "acceptedByTitle": "acceptedByTitle",
              "notes": "notes",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/acts/cancel")
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

        var response = await Client.Sales.PostV1SalesActsCancelAsync(
            new PostV1SalesActsCancelRequest { Id = "x" }
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
              "partnerId": "partnerId",
              "type": "goods",
              "status": "draft",
              "series": "series",
              "fullNumber": "fullNumber",
              "documentDate": "documentDate",
              "saleInvoiceId": "saleInvoiceId",
              "transferredByName": "transferredByName",
              "transferredByTitle": "transferredByTitle",
              "acceptedByName": "acceptedByName",
              "acceptedByTitle": "acceptedByTitle",
              "notes": "notes",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/acts/cancel")
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

        var response = await Client.Sales.PostV1SalesActsCancelAsync(
            new PostV1SalesActsCancelRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
