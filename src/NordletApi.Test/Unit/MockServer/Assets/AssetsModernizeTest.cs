using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AssetsModernizeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
              "date": "2023-01-15",
              "amount": "amount"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "groupId": "x",
              "code": "code",
              "name": "name",
              "acquisitionDate": "2023-01-15",
              "depreciationStartDate": "2023-01-15",
              "acquisitionCost": "acquisitionCost",
              "salvageValue": "salvageValue",
              "usefulLifeMonths": 1000000,
              "totalCost": "totalCost",
              "accumulatedDepreciation": "accumulatedDepreciation",
              "netBookValue": "netBookValue",
              "depreciatedMonths": 1000000,
              "totalLifeMonths": 1000000,
              "status": "active",
              "notes": "notes",
              "documents": [
                {
                  "name": "x",
                  "ref": "x"
                },
                {
                  "name": "x",
                  "ref": "x"
                }
              ],
              "inputVatAmount": "inputVatAmount",
              "inputVatFirstUseDate": "2023-01-15",
              "inputVatDeductiblePercent": "inputVatDeductiblePercent",
              "inputVatRealEstate": true,
              "inputVatUseChanges": [
                {
                  "year": 1000000,
                  "percent": "percent",
                  "reason": "use_change"
                },
                {
                  "year": 1000000,
                  "percent": "percent",
                  "reason": "use_change"
                }
              ],
              "disposalDate": "2023-01-15",
              "disposalReason": "sold",
              "disposalProceeds": "disposalProceeds",
              "disposalJournalTransactionId": "disposalJournalTransactionId",
              "createdAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/modernize")
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

        var response = await Client.Assets.AssetsModernizeAsync(
            new AssetsModernizeAssetsRequest
            {
                Id = "x",
                Date = new DateOnly(2023, 1, 15),
                Amount = "amount",
                AddedLifeMonths = null,
                Notes = null,
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
              "date": "2026-07-01",
              "amount": "121.0000"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "groupId": "groupId",
              "code": "code",
              "name": "name",
              "acquisitionDate": "2026-07-01",
              "depreciationStartDate": "2026-07-01",
              "acquisitionCost": "acquisitionCost",
              "salvageValue": "salvageValue",
              "usefulLifeMonths": 1000000,
              "totalCost": "totalCost",
              "accumulatedDepreciation": "accumulatedDepreciation",
              "netBookValue": "netBookValue",
              "depreciatedMonths": 1000000,
              "totalLifeMonths": 1000000,
              "status": "active",
              "notes": "notes",
              "documents": [
                {
                  "name": "name",
                  "ref": "ref"
                }
              ],
              "inputVatAmount": "inputVatAmount",
              "inputVatFirstUseDate": "2026-07-01",
              "inputVatDeductiblePercent": "inputVatDeductiblePercent",
              "inputVatRealEstate": true,
              "inputVatUseChanges": [
                {
                  "year": 1000000,
                  "percent": "121.00",
                  "reason": "use_change"
                }
              ],
              "disposalDate": "2026-07-01",
              "disposalReason": "sold",
              "disposalProceeds": "disposalProceeds",
              "disposalJournalTransactionId": "disposalJournalTransactionId",
              "createdAt": "2026-07-01T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/modernize")
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

        var response = await Client.Assets.AssetsModernizeAsync(
            new AssetsModernizeAssetsRequest
            {
                Id = "id",
                Date = new DateOnly(2026, 7, 1),
                Amount = "121.0000",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
