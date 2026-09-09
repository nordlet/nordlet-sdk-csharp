using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Sales;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1OperationTypesGetTest : BaseMockServerTest
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
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/operation-types/get")
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

        var response = await Client.Sales.PostV1OperationTypesGetAsync(
            new PostV1OperationTypesGetRequest { Id = "x" }
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
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/operation-types/get")
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

        var response = await Client.Sales.PostV1OperationTypesGetAsync(
            new PostV1OperationTypesGetRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
