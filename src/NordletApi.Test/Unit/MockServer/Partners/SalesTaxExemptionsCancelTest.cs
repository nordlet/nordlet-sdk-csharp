using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SalesTaxExemptionsCancelTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "cancelledOn": "2023-01-15"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/sales-tax-exemptions/cancel")
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

        var response = await Client.Partners.SalesTaxExemptionsCancelAsync(
            new SalesTaxExemptionsCancelPartnersRequest
            {
                Id = "x",
                CancelledOn = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "id": "id",
              "cancelledOn": "2026-07-01"
            }
            """;

        const string mockResponse = """
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/sales-tax-exemptions/cancel")
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

        var response = await Client.Partners.SalesTaxExemptionsCancelAsync(
            new SalesTaxExemptionsCancelPartnersRequest
            {
                Id = "id",
                CancelledOn = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
