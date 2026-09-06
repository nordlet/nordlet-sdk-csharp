using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1SalesInvoicesListTest : BaseMockServerTest
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
                  "type": "invoice",
                  "status": "draft",
                  "paymentStatus": "unpaid",
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "issueDate": "issueDate",
                  "dueDate": "dueDate",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "x",
                  "appliedToInvoiceId": "x",
                  "creditedInvoiceId": "x",
                  "agreementId": "x",
                  "vatScheme": "domestic",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true,
                  "notes": "notes",
                  "documentRef": "documentRef",
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "partnerId": "x",
                  "type": "invoice",
                  "status": "draft",
                  "paymentStatus": "unpaid",
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "issueDate": "issueDate",
                  "dueDate": "dueDate",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "x",
                  "appliedToInvoiceId": "x",
                  "creditedInvoiceId": "x",
                  "agreementId": "x",
                  "vatScheme": "domestic",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true,
                  "notes": "notes",
                  "documentRef": "documentRef",
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
                    .WithPath("/v1/sales/invoices/list")
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

        var response = await Client.Sales.PostV1SalesInvoicesListAsync(
            new PostV1SalesInvoicesListRequest
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
                  "type": "invoice",
                  "status": "draft",
                  "paymentStatus": "unpaid",
                  "series": "series",
                  "number": 1000000,
                  "fullNumber": "fullNumber",
                  "issueDate": "issueDate",
                  "dueDate": "dueDate",
                  "currency": "currency",
                  "netTotal": "netTotal",
                  "vatTotal": "vatTotal",
                  "grossTotal": "grossTotal",
                  "paidAmount": "paidAmount",
                  "journalTransactionId": "journalTransactionId",
                  "appliedToInvoiceId": "appliedToInvoiceId",
                  "creditedInvoiceId": "creditedInvoiceId",
                  "agreementId": "agreementId",
                  "vatScheme": "domestic",
                  "vatCountryCode": "vatCountryCode",
                  "deemedSupplier": true,
                  "notes": "notes",
                  "documentRef": "documentRef",
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
                    .WithPath("/v1/sales/invoices/list")
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

        var response = await Client.Sales.PostV1SalesInvoicesListAsync(
            new PostV1SalesInvoicesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
