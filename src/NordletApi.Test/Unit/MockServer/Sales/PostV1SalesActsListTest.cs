using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesActsListTest : BaseMockServerTest
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
                },
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
                    .WithPath("/v1/sales/acts/list")
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

        var response = await Client.Sales.PostV1SalesActsListAsync(
            new PostV1SalesActsListRequest
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
                    .WithPath("/v1/sales/acts/list")
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

        var response = await Client.Sales.PostV1SalesActsListAsync(
            new PostV1SalesActsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
