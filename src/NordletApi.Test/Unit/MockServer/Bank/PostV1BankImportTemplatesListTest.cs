using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1BankImportTemplatesListTest : BaseMockServerTest
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
                },
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
                    .WithPath("/v1/bank/import-templates/list")
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

        var response = await Client.Bank.PostV1BankImportTemplatesListAsync(
            new PostV1BankImportTemplatesListRequest
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
                  "name": "name",
                  "type": "stripe",
                  "fields": [
                    {
                      "name": "name",
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
                    .WithPath("/v1/bank/import-templates/list")
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

        var response = await Client.Bank.PostV1BankImportTemplatesListAsync(
            new PostV1BankImportTemplatesListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
