using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Account;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CompaniesContextTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "periods": {
                "open": [
                  {
                    "year": 1000000,
                    "month": 1000000
                  },
                  {
                    "year": 1000000,
                    "month": 1000000
                  }
                ],
                "locked": [
                  {
                    "year": 1000000,
                    "month": 1000000
                  },
                  {
                    "year": 1000000,
                    "month": 1000000
                  }
                ]
              },
              "postingRules": {
                "postingRules": "postingRules"
              },
              "bankAccounts": [
                {
                  "id": "x",
                  "name": "name",
                  "type": "type",
                  "iban": "iban",
                  "currency": "currency",
                  "accountCode": "accountCode",
                  "isActive": true
                },
                {
                  "id": "x",
                  "name": "name",
                  "type": "type",
                  "iban": "iban",
                  "currency": "currency",
                  "accountCode": "accountCode",
                  "isActive": true
                }
              ],
              "vatTypesUsed": [
                {
                  "code": "code",
                  "name": "name",
                  "ratePercent": "ratePercent",
                  "saleLines": 1000000,
                  "purchaseLines": 1000000
                },
                {
                  "code": "code",
                  "name": "name",
                  "ratePercent": "ratePercent",
                  "saleLines": 1000000,
                  "purchaseLines": 1000000
                }
              ],
              "filings": [
                {
                  "key": "key",
                  "ruleKey": "ruleKey",
                  "period": "period",
                  "title": "title",
                  "dueDate": "2023-01-15",
                  "system": "system",
                  "canDownload": true,
                  "canSubmit": true,
                  "missingSettings": {
                    "operation": "declarations/configs/update",
                    "system": "system",
                    "keys": [
                      "keys",
                      "keys"
                    ],
                    "call": "call"
                  }
                },
                {
                  "key": "key",
                  "ruleKey": "ruleKey",
                  "period": "period",
                  "title": "title",
                  "dueDate": "2023-01-15",
                  "system": "system",
                  "canDownload": true,
                  "canSubmit": true,
                  "missingSettings": {
                    "operation": "declarations/configs/update",
                    "system": "system",
                    "keys": [
                      "keys",
                      "keys"
                    ],
                    "call": "call"
                  }
                }
              ],
              "payroll": {
                "country": "country",
                "engine": true,
                "employeeFields": [
                  {
                    "key": "key",
                    "kind": "text",
                    "options": [
                      "options",
                      "options"
                    ],
                    "maxLength": 1000000
                  },
                  {
                    "key": "key",
                    "kind": "text",
                    "options": [
                      "options",
                      "options"
                    ],
                    "maxLength": 1000000
                  }
                ]
              },
              "profile": {
                "id": "x",
                "name": "name",
                "code": "code",
                "vatCode": "vatCode",
                "identifiers": {
                  "identifiers": "identifiers"
                },
                "smeExemptionNumber": "smeExemptionNumber",
                "isVatPayer": true,
                "isSandbox": true,
                "cashBasis": true,
                "countryCode": "countryCode",
                "chartTemplate": "chartTemplate",
                "countryChartTemplate": "countryChartTemplate",
                "baseCurrency": "baseCurrency",
                "defaultInvoiceCurrency": "defaultInvoiceCurrency",
                "status": "active",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "xy",
                  "subdivision": "subdivision"
                },
                "email": "email",
                "phone": "phone",
                "iban": "iban",
                "bankName": "bankName",
                "bankBic": "bankBic",
                "bankCode": "bankCode",
                "bankBranchCode": "bankBranchCode",
                "bankAccountNumber": "bankAccountNumber",
                "invoicePrefix": "invoicePrefix",
                "nextInvoiceNumber": "nextInvoiceNumber",
                "defaultInvoiceLocale": "defaultInvoiceLocale",
                "defaultInvoiceNote": "defaultInvoiceNote",
                "peppolId": "peppolId",
                "sepaCreditorId": "sepaCreditorId",
                "logoFileId": "logoFileId",
                "legalForm": "legalForm",
                "registryName": "registryName",
                "incorporatedOn": "incorporatedOn",
                "shareCapital": "shareCapital",
                "accountsKeptBy": "company",
                "vatPeriod": "monthly",
                "vatPeriodEndMonth": 1000000,
                "fiscalYearEndMonth": 1000000,
                "fiscalYearEndDay": 1000000,
                "fiscalYearWeekday": 1000000,
                "fiscalYearWeekRule": "last",
                "timeZone": "timeZone",
                "filingOptions": {
                  "filingOptions": "filingOptions"
                },
                "bookkeeperName": "bookkeeperName",
                "auditorName": "auditorName",
                "auditorRegistrationNumber": "auditorRegistrationNumber",
                "auditRequired": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/context")
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

        var response = await Client.Account.CompaniesContextAsync(
            new CompaniesContextAccountRequest()
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
              "periods": {
                "open": [
                  {
                    "year": 1000000,
                    "month": 1000000
                  }
                ],
                "locked": [
                  {
                    "year": 1000000,
                    "month": 1000000
                  }
                ]
              },
              "postingRules": {
                "key": "value"
              },
              "bankAccounts": [
                {
                  "id": "id",
                  "name": "name",
                  "type": "type",
                  "iban": "iban",
                  "currency": "currency",
                  "accountCode": "accountCode",
                  "isActive": true
                }
              ],
              "vatTypesUsed": [
                {
                  "code": "code",
                  "name": "name",
                  "ratePercent": "ratePercent",
                  "saleLines": 1000000,
                  "purchaseLines": 1000000
                }
              ],
              "filings": [
                {
                  "key": "key",
                  "ruleKey": "ruleKey",
                  "period": "period",
                  "title": "title",
                  "dueDate": "2026-07-01",
                  "system": "system",
                  "canDownload": true,
                  "canSubmit": true,
                  "missingSettings": {
                    "operation": "declarations/configs/update",
                    "system": "system",
                    "keys": [
                      "keys"
                    ],
                    "call": "call"
                  }
                }
              ],
              "payroll": {
                "country": "country",
                "engine": true,
                "employeeFields": [
                  {
                    "key": "key",
                    "kind": "text"
                  }
                ]
              },
              "profile": {
                "id": "id",
                "name": "name",
                "code": "code",
                "vatCode": "vatCode",
                "identifiers": {
                  "key": "value"
                },
                "smeExemptionNumber": "smeExemptionNumber",
                "isVatPayer": true,
                "isSandbox": true,
                "cashBasis": true,
                "countryCode": "countryCode",
                "chartTemplate": "chartTemplate",
                "countryChartTemplate": "countryChartTemplate",
                "baseCurrency": "baseCurrency",
                "defaultInvoiceCurrency": "defaultInvoiceCurrency",
                "status": "active",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "countryCode",
                  "subdivision": "subdivision"
                },
                "email": "email",
                "phone": "phone",
                "iban": "iban",
                "bankName": "bankName",
                "bankBic": "bankBic",
                "bankCode": "bankCode",
                "bankBranchCode": "bankBranchCode",
                "bankAccountNumber": "bankAccountNumber",
                "invoicePrefix": "invoicePrefix",
                "nextInvoiceNumber": "nextInvoiceNumber",
                "defaultInvoiceLocale": "defaultInvoiceLocale",
                "defaultInvoiceNote": "defaultInvoiceNote",
                "peppolId": "peppolId",
                "sepaCreditorId": "sepaCreditorId",
                "logoFileId": "logoFileId",
                "legalForm": "legalForm",
                "registryName": "registryName",
                "incorporatedOn": "incorporatedOn",
                "shareCapital": "shareCapital",
                "accountsKeptBy": "company",
                "vatPeriod": "monthly",
                "vatPeriodEndMonth": 1000000,
                "fiscalYearEndMonth": 1000000,
                "fiscalYearEndDay": 1000000,
                "fiscalYearWeekday": 1000000,
                "fiscalYearWeekRule": "last",
                "timeZone": "timeZone",
                "filingOptions": {
                  "key": "value"
                },
                "bookkeeperName": "bookkeeperName",
                "auditorName": "auditorName",
                "auditorRegistrationNumber": "auditorRegistrationNumber",
                "auditRequired": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/account/companies/context")
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

        var response = await Client.Account.CompaniesContextAsync(
            new CompaniesContextAccountRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
