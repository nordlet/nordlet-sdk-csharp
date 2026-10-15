using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Bank;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ImportTemplatesListBuiltinTest : BaseMockServerTest
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
                  "builtin": true,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
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
                  "builtin": true,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/import-templates/list-builtin")
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

        var response = await Client.Bank.ImportTemplatesListBuiltinAsync(
            new ImportTemplatesListBuiltinBankRequest()
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
                  "builtin": true,
                  "createdAt": "2026-07-01T09:30:00.000Z",
                  "updatedAt": "2026-07-01T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/bank/import-templates/list-builtin")
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

        var response = await Client.Bank.ImportTemplatesListBuiltinAsync(
            new ImportTemplatesListBuiltinBankRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
