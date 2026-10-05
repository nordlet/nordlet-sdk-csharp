using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.OperationTypes;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/operation-types/update")
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

        var response = await Client.OperationTypes.UpdateAsync(
            new UpdateOperationTypesRequest
            {
                Id = "x",
                Code = null,
                Name = null,
                InvoiceType = null,
                PayerPartnerId = null,
                DebitAccountCode = null,
                CreditAccountCode = null,
                VatAccountCode = null,
                ExpenseAccountCode = null,
                AdvanceAccountCode = null,
                IncomeAccountCode = null,
                IsPurchase = null,
                IsSale = null,
                IsWriteOff = null,
                IsInternalMovement = null,
                IsPurchaseReturn = null,
                IsSalesReturn = null,
                IsConsignment = null,
                IsProduction = null,
                IsAssetIn = null,
                IsAssetOut = null,
                IsCashRegisterSale = null,
                IncludeInVatRegister = null,
                IncludeInSaft = null,
                IsActive = null,
                SortOrder = null,
            }
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/operation-types/update")
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

        var response = await Client.OperationTypes.UpdateAsync(
            new UpdateOperationTypesRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
