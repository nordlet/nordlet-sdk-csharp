using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class EuOwnGoodsTransfersComputeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "periodYear": 1000000,
              "periodMonth": 1000000,
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "dueDate": "2023-01-15",
              "memberStateOfIdentification": "memberStateOfIdentification",
              "currency": "currency",
              "rows": [
                {
                  "destinationCountryCode": "destinationCountryCode",
                  "dispatchCountryCode": "dispatchCountryCode",
                  "taxableAmount": "taxableAmount",
                  "transfers": 1000000
                },
                {
                  "destinationCountryCode": "destinationCountryCode",
                  "dispatchCountryCode": "dispatchCountryCode",
                  "taxableAmount": "taxableAmount",
                  "transfers": 1000000
                }
              ],
              "total": "total",
              "transfers": [
                {
                  "movementId": "movementId",
                  "date": "2023-01-15",
                  "itemId": "itemId",
                  "itemName": "itemName",
                  "quantity": "quantity",
                  "cost": "cost",
                  "fromCountryCode": "fromCountryCode",
                  "toCountryCode": "toCountryCode"
                },
                {
                  "movementId": "movementId",
                  "date": "2023-01-15",
                  "itemId": "itemId",
                  "itemName": "itemName",
                  "quantity": "quantity",
                  "cost": "cost",
                  "fromCountryCode": "fromCountryCode",
                  "toCountryCode": "toCountryCode"
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/own-goods-transfers/compute")
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

        var response = await Client.Declarations.EuOwnGoodsTransfersComputeAsync(
            new EuOwnGoodsTransfersComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "month": 1000000
            }
            """;

        const string mockResponse = """
            {
              "periodYear": 1000000,
              "periodMonth": 1000000,
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "dueDate": "2026-07-01",
              "memberStateOfIdentification": "memberStateOfIdentification",
              "currency": "currency",
              "rows": [
                {
                  "destinationCountryCode": "destinationCountryCode",
                  "dispatchCountryCode": "dispatchCountryCode",
                  "taxableAmount": "taxableAmount",
                  "transfers": 1000000
                }
              ],
              "total": "total",
              "transfers": [
                {
                  "movementId": "movementId",
                  "date": "2026-07-01",
                  "itemId": "itemId",
                  "itemName": "itemName",
                  "quantity": "quantity",
                  "cost": "cost",
                  "fromCountryCode": "fromCountryCode",
                  "toCountryCode": "toCountryCode"
                }
              ],
              "warnings": [
                "warnings"
              ],
              "source": "source"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/eu/own-goods-transfers/compute")
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

        var response = await Client.Declarations.EuOwnGoodsTransfersComputeAsync(
            new EuOwnGoodsTransfersComputeDeclarationsRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
