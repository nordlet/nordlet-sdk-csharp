using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesActsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x"
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
              "updatedAt": "updatedAt",
              "lines": [
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "lineNet": "lineNet",
                  "sortOrder": 1000000
                },
                {
                  "id": "x",
                  "itemId": "x",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "lineNet": "lineNet",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/acts/create")
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

        var response = await Client.Sales.PostV1SalesActsCreateAsync(
            new PostV1SalesActsCreateRequest
            {
                PartnerId = "x",
                Type = null,
                DocumentDate = null,
                SaleInvoiceId = null,
                TransferredByName = null,
                TransferredByTitle = null,
                AcceptedByName = null,
                AcceptedByTitle = null,
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
              "partnerId": "partnerId"
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
              "updatedAt": "updatedAt",
              "lines": [
                {
                  "id": "id",
                  "itemId": "itemId",
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPriceExclVat": "unitPriceExclVat",
                  "lineNet": "lineNet",
                  "sortOrder": 1000000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/sales/acts/create")
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

        var response = await Client.Sales.PostV1SalesActsCreateAsync(
            new PostV1SalesActsCreateRequest { PartnerId = "partnerId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
