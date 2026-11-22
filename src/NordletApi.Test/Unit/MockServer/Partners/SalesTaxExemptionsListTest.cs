using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SalesTaxExemptionsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "items": [
                {
                  "id": "x",
                  "partnerId": "x",
                  "state": "state",
                  "reasons": [
                    "reasons",
                    "reasons"
                  ],
                  "otherReason": "otherReason",
                  "reasonDetail": "reasonDetail",
                  "businessType": "businessType",
                  "otherBusinessType": "otherBusinessType",
                  "idNumber": "idNumber",
                  "idIssuedBy": "idIssuedBy",
                  "singlePurchaseReference": "singlePurchaseReference",
                  "signedBy": "signedBy",
                  "signerTitle": "signerTitle",
                  "signedOn": "signedOn",
                  "receivedOn": "receivedOn",
                  "cancelledOn": "cancelledOn"
                },
                {
                  "id": "x",
                  "partnerId": "x",
                  "state": "state",
                  "reasons": [
                    "reasons",
                    "reasons"
                  ],
                  "otherReason": "otherReason",
                  "reasonDetail": "reasonDetail",
                  "businessType": "businessType",
                  "otherBusinessType": "otherBusinessType",
                  "idNumber": "idNumber",
                  "idIssuedBy": "idIssuedBy",
                  "singlePurchaseReference": "singlePurchaseReference",
                  "signedBy": "signedBy",
                  "signerTitle": "signerTitle",
                  "signedOn": "signedOn",
                  "receivedOn": "receivedOn",
                  "cancelledOn": "cancelledOn"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/sales-tax-exemptions/list")
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

        var response = await Client.Partners.SalesTaxExemptionsListAsync(
            new SalesTaxExemptionsListPartnersRequest { PartnerId = null }
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
              "items": [
                {
                  "id": "id",
                  "partnerId": "partnerId",
                  "state": "state",
                  "reasons": [
                    "reasons"
                  ],
                  "otherReason": "otherReason",
                  "reasonDetail": "reasonDetail",
                  "businessType": "businessType",
                  "otherBusinessType": "otherBusinessType",
                  "idNumber": "idNumber",
                  "idIssuedBy": "idIssuedBy",
                  "singlePurchaseReference": "singlePurchaseReference",
                  "signedBy": "signedBy",
                  "signerTitle": "signerTitle",
                  "signedOn": "signedOn",
                  "receivedOn": "receivedOn",
                  "cancelledOn": "cancelledOn"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/sales-tax-exemptions/list")
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

        var response = await Client.Partners.SalesTaxExemptionsListAsync(
            new SalesTaxExemptionsListPartnersRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
