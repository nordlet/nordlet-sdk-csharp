using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Public;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InvoicesGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "token": "blackcurrant...."
            }
            """;

        const string mockResponse = """
            {
              "type": "invoice",
              "status": "draft",
              "paymentStatus": "unpaid",
              "number": "number",
              "issueDate": "2023-01-15",
              "dueDate": "2023-01-15",
              "currency": "currency",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "salesTaxPercent": "salesTaxPercent",
              "salesTaxTotal": "salesTaxTotal",
              "grossTotal": "grossTotal",
              "paidAmount": "paidAmount",
              "paidOn": "paidOn",
              "notes": "notes",
              "payUrl": "payUrl",
              "seller": {
                "name": "name",
                "vatCode": "vatCode",
                "countryCode": "countryCode",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "countryCode"
                },
                "email": "email",
                "iban": "iban",
                "bankName": "bankName",
                "bankBic": "bankBic",
                "bankCode": "bankCode",
                "bankBranchCode": "bankBranchCode",
                "bankAccountNumber": "bankAccountNumber"
              },
              "buyer": {
                "name": "name",
                "vatCode": "vatCode",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "countryCode"
                },
                "email": "email"
              },
              "lines": [
                {
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPrice": "unitPrice",
                  "vatRatePercent": "vatRatePercent",
                  "lineNet": "lineNet"
                },
                {
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPrice": "unitPrice",
                  "vatRatePercent": "vatRatePercent",
                  "lineNet": "lineNet"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/public/invoices/get")
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

        var response = await Client.Public.InvoicesGetAsync(
            new InvoicesGetPublicRequest { Token = "blackcurrant...." }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "token": "token"
            }
            """;

        const string mockResponse = """
            {
              "type": "invoice",
              "status": "draft",
              "paymentStatus": "unpaid",
              "number": "number",
              "issueDate": "2026-07-01",
              "dueDate": "2026-07-01",
              "currency": "currency",
              "netTotal": "netTotal",
              "vatTotal": "vatTotal",
              "salesTaxPercent": "salesTaxPercent",
              "salesTaxTotal": "salesTaxTotal",
              "grossTotal": "grossTotal",
              "paidAmount": "paidAmount",
              "paidOn": "paidOn",
              "notes": "notes",
              "payUrl": "payUrl",
              "seller": {
                "name": "name",
                "vatCode": "vatCode",
                "countryCode": "countryCode",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "countryCode"
                },
                "email": "email",
                "iban": "iban",
                "bankName": "bankName",
                "bankBic": "bankBic",
                "bankCode": "bankCode",
                "bankBranchCode": "bankBranchCode",
                "bankAccountNumber": "bankAccountNumber"
              },
              "buyer": {
                "name": "name",
                "vatCode": "vatCode",
                "address": {
                  "street": "street",
                  "city": "city",
                  "postalCode": "postalCode",
                  "countryCode": "countryCode"
                },
                "email": "email"
              },
              "lines": [
                {
                  "description": "description",
                  "unit": "unit",
                  "quantity": "quantity",
                  "unitPrice": "unitPrice",
                  "vatRatePercent": "vatRatePercent",
                  "lineNet": "lineNet"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/public/invoices/get")
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

        var response = await Client.Public.InvoicesGetAsync(
            new InvoicesGetPublicRequest { Token = "token" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
