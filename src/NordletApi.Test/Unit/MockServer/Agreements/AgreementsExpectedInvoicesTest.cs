using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AgreementsExpectedInvoicesTest : BaseMockServerTest
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
              "agreementId": "x",
              "number": "number",
              "currency": "currency",
              "periods": [
                {
                  "periodStart": "periodStart",
                  "periodEnd": "periodEnd",
                  "expectedNet": "expectedNet",
                  "missing": true,
                  "purchaseInvoices": [
                    {
                      "id": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "status": "draft",
                      "type": "invoice",
                      "netTotal": "netTotal",
                      "currency": "currency"
                    },
                    {
                      "id": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "status": "draft",
                      "type": "invoice",
                      "netTotal": "netTotal",
                      "currency": "currency"
                    }
                  ]
                },
                {
                  "periodStart": "periodStart",
                  "periodEnd": "periodEnd",
                  "expectedNet": "expectedNet",
                  "missing": true,
                  "purchaseInvoices": [
                    {
                      "id": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "status": "draft",
                      "type": "invoice",
                      "netTotal": "netTotal",
                      "currency": "currency"
                    },
                    {
                      "id": "x",
                      "documentNumber": "documentNumber",
                      "documentDate": "2023-01-15",
                      "status": "draft",
                      "type": "invoice",
                      "netTotal": "netTotal",
                      "currency": "currency"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/expected-invoices")
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

        var response = await Client.Agreements.AgreementsExpectedInvoicesAsync(
            new AgreementsExpectedInvoicesAgreementsRequest { Id = "x", To = null }
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
              "agreementId": "agreementId",
              "number": "number",
              "currency": "currency",
              "periods": [
                {
                  "periodStart": "periodStart",
                  "periodEnd": "periodEnd",
                  "expectedNet": "expectedNet",
                  "missing": true,
                  "purchaseInvoices": [
                    {
                      "id": "id",
                      "documentNumber": "documentNumber",
                      "documentDate": "2026-07-01",
                      "status": "draft",
                      "type": "invoice",
                      "netTotal": "netTotal",
                      "currency": "currency"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/agreements/expected-invoices")
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

        var response = await Client.Agreements.AgreementsExpectedInvoicesAsync(
            new AgreementsExpectedInvoicesAgreementsRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
