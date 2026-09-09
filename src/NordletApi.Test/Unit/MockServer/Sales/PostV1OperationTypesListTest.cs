using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1OperationTypesListTest : BaseMockServerTest
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
                  "code": "code",
                  "name": "name",
                  "invoiceType": "invoice",
                  "payerPartnerId": "x",
                  "debitAccountCode": "debitAccountCode",
                  "creditAccountCode": "creditAccountCode",
                  "vatAccountCode": "vatAccountCode",
                  "expenseAccountCode": "expenseAccountCode",
                  "advanceAccountCode": "advanceAccountCode",
                  "incomeAccountCode": "incomeAccountCode",
                  "isPurchase": true,
                  "isSale": true,
                  "isWriteOff": true,
                  "isInternalMovement": true,
                  "isPurchaseReturn": true,
                  "isSalesReturn": true,
                  "isConsignment": true,
                  "isProduction": true,
                  "isAssetIn": true,
                  "isAssetOut": true,
                  "isCashRegisterSale": true,
                  "includeInVatRegister": true,
                  "includeInSaft": true,
                  "isActive": true,
                  "sortOrder": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                },
                {
                  "id": "x",
                  "code": "code",
                  "name": "name",
                  "invoiceType": "invoice",
                  "payerPartnerId": "x",
                  "debitAccountCode": "debitAccountCode",
                  "creditAccountCode": "creditAccountCode",
                  "vatAccountCode": "vatAccountCode",
                  "expenseAccountCode": "expenseAccountCode",
                  "advanceAccountCode": "advanceAccountCode",
                  "incomeAccountCode": "incomeAccountCode",
                  "isPurchase": true,
                  "isSale": true,
                  "isWriteOff": true,
                  "isInternalMovement": true,
                  "isPurchaseReturn": true,
                  "isSalesReturn": true,
                  "isConsignment": true,
                  "isProduction": true,
                  "isAssetIn": true,
                  "isAssetOut": true,
                  "isCashRegisterSale": true,
                  "includeInVatRegister": true,
                  "includeInSaft": true,
                  "isActive": true,
                  "sortOrder": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "totals": "totals"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/operation-types/list")
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

        var response = await Client.Sales.PostV1OperationTypesListAsync(
            new PostV1OperationTypesListRequest
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
                  "code": "code",
                  "name": "name",
                  "invoiceType": "invoice",
                  "payerPartnerId": "payerPartnerId",
                  "debitAccountCode": "debitAccountCode",
                  "creditAccountCode": "creditAccountCode",
                  "vatAccountCode": "vatAccountCode",
                  "expenseAccountCode": "expenseAccountCode",
                  "advanceAccountCode": "advanceAccountCode",
                  "incomeAccountCode": "incomeAccountCode",
                  "isPurchase": true,
                  "isSale": true,
                  "isWriteOff": true,
                  "isInternalMovement": true,
                  "isPurchaseReturn": true,
                  "isSalesReturn": true,
                  "isConsignment": true,
                  "isProduction": true,
                  "isAssetIn": true,
                  "isAssetOut": true,
                  "isCashRegisterSale": true,
                  "includeInVatRegister": true,
                  "includeInSaft": true,
                  "isActive": true,
                  "sortOrder": 1000000,
                  "createdAt": "createdAt",
                  "updatedAt": "updatedAt"
                }
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000,
              "totals": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/operation-types/list")
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

        var response = await Client.Sales.PostV1OperationTypesListAsync(
            new PostV1OperationTypesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
