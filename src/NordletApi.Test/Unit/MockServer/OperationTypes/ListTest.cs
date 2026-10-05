using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.OperationTypes;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
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
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.OperationTypes.ListAsync(
            new ListOperationTypesRequest
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
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.OperationTypes.ListAsync(new ListOperationTypesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
