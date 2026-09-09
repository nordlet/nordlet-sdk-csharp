using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankImportTemplatesUpdateTest : BaseMockServerTest
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
              "name": "name",
              "type": "stripe",
              "fields": [
                {
                  "name": "name",
                  "accountCode": "accountCode",
                  "createPartner": true
                },
                {
                  "name": "name",
                  "accountCode": "accountCode",
                  "createPartner": true
                }
              ],
              "metaFields": [
                "metaFields",
                "metaFields"
              ],
              "invoiceMetaField": "invoiceMetaField",
              "invoiceVatRatePercent": "invoiceVatRatePercent",
              "companyMetaField": "companyMetaField",
              "invoiceItemId": "x",
              "advanceInvoices": true,
              "authorizationOperationTypeId": "x",
              "payoutOperationTypeId": "x",
              "commissionOperationTypeId": "x",
              "lenderMetaField": "lenderMetaField",
              "partialRefundLabel": "partialRefundLabel",
              "fullRefundLabel": "fullRefundLabel",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/import-templates/update")
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

        var response = await Client.Bank.PostV1BankImportTemplatesUpdateAsync(
            new PostV1BankImportTemplatesUpdateRequest
            {
                Name = null,
                Type = null,
                Fields = null,
                MetaFields = null,
                InvoiceMetaField = null,
                InvoiceVatRatePercent = null,
                CompanyMetaField = null,
                InvoiceItemId = null,
                AdvanceInvoices = null,
                AuthorizationOperationTypeId = null,
                PayoutOperationTypeId = null,
                CommissionOperationTypeId = null,
                LenderMetaField = null,
                PartialRefundLabel = null,
                FullRefundLabel = null,
                Id = "x",
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
              "name": "name",
              "type": "stripe",
              "fields": [
                {
                  "name": "name",
                  "accountCode": "accountCode",
                  "createPartner": true
                }
              ],
              "metaFields": [
                "metaFields"
              ],
              "invoiceMetaField": "invoiceMetaField",
              "invoiceVatRatePercent": "invoiceVatRatePercent",
              "companyMetaField": "companyMetaField",
              "invoiceItemId": "invoiceItemId",
              "advanceInvoices": true,
              "authorizationOperationTypeId": "authorizationOperationTypeId",
              "payoutOperationTypeId": "payoutOperationTypeId",
              "commissionOperationTypeId": "commissionOperationTypeId",
              "lenderMetaField": "lenderMetaField",
              "partialRefundLabel": "partialRefundLabel",
              "fullRefundLabel": "fullRefundLabel",
              "createdAt": "createdAt",
              "updatedAt": "updatedAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/import-templates/update")
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

        var response = await Client.Bank.PostV1BankImportTemplatesUpdateAsync(
            new PostV1BankImportTemplatesUpdateRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
