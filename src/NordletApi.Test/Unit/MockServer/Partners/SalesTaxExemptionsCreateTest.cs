using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SalesTaxExemptionsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "partnerId": "x",
              "state": "US-AR",
              "reasons": [
                "A",
                "A"
              ],
              "businessType": "10",
              "idNumber": "x",
              "idIssuedBy": "xy",
              "receivedOn": "2023-01-15"
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
                    .WithPath("/v1/partners/sales-tax-exemptions/create")
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

        var response = await Client.Partners.SalesTaxExemptionsCreateAsync(
            new SalesTaxExemptionsCreatePartnersRequest
            {
                PartnerId = "x",
                State = SalesTaxExemptionsCreatePartnersRequestState.UsAr,
                Reasons = new List<SalesTaxExemptionsCreatePartnersRequestReasonsItem>()
                {
                    SalesTaxExemptionsCreatePartnersRequestReasonsItem.A,
                    SalesTaxExemptionsCreatePartnersRequestReasonsItem.A,
                },
                OtherReason = null,
                ReasonDetail = null,
                BusinessType = SalesTaxExemptionsCreatePartnersRequestBusinessType.Ten,
                OtherBusinessType = null,
                IdNumber = "x",
                IdIssuedBy = "xy",
                SinglePurchaseReference = null,
                SignedBy = null,
                SignerTitle = null,
                SignedOn = null,
                ReceivedOn = new DateOnly(2023, 1, 15),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "partnerId": "partnerId",
              "state": "US-AR",
              "reasons": [
                "A"
              ],
              "businessType": "10",
              "idNumber": "idNumber",
              "idIssuedBy": "idIssuedBy",
              "receivedOn": "2026-07-01"
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
                    .WithPath("/v1/partners/sales-tax-exemptions/create")
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

        var response = await Client.Partners.SalesTaxExemptionsCreateAsync(
            new SalesTaxExemptionsCreatePartnersRequest
            {
                PartnerId = "partnerId",
                State = SalesTaxExemptionsCreatePartnersRequestState.UsAr,
                Reasons = new List<SalesTaxExemptionsCreatePartnersRequestReasonsItem>()
                {
                    SalesTaxExemptionsCreatePartnersRequestReasonsItem.A,
                },
                BusinessType = SalesTaxExemptionsCreatePartnersRequestBusinessType.Ten,
                IdNumber = "idNumber",
                IdIssuedBy = "idIssuedBy",
                ReceivedOn = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
