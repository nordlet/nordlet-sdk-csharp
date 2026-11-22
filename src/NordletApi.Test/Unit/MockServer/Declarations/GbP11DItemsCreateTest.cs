using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbP11DItemsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId",
              "taxYear": 1000000,
              "item": {
                "type": "asset-transferred",
                "asset": "cars",
                "cost": "cost",
                "madeGood": "madeGood"
              }
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "taxYear": 1.1,
              "section": "section",
              "class1A": true,
              "cashEquivalent": "cashEquivalent",
              "item": {
                "type": "asset-transferred",
                "asset": "cars",
                "otherDescription": "x",
                "cost": "cost",
                "madeGood": "madeGood"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/p11d/items/create")
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

        var response = await Client.Declarations.GbP11DItemsCreateAsync(
            new GbP11DItemsCreateDeclarationsRequest
            {
                EmployeeId = "employeeId",
                TaxYear = 1000000,
                Item = new GbP11DItemsCreateDeclarationsRequestItem(
                    new GbP11DItemsCreateDeclarationsRequestItem.AssetTransferred(
                        new GbP11DItemsCreateDeclarationsRequestItemAssetTransferred
                        {
                            Asset =
                                GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset.Cars,
                            OtherDescription = null,
                            Cost = "cost",
                            MadeGood = "madeGood",
                        }
                    )
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId",
              "taxYear": 1000000,
              "item": {
                "type": "asset-transferred",
                "asset": "cars",
                "cost": "121.00",
                "madeGood": "121.00"
              }
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "taxYear": 1.1,
              "section": "section",
              "class1A": true,
              "cashEquivalent": "cashEquivalent",
              "item": {
                "type": "asset-transferred",
                "asset": "cars",
                "otherDescription": "otherDescription",
                "cost": "121.00",
                "madeGood": "121.00"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/p11d/items/create")
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

        var response = await Client.Declarations.GbP11DItemsCreateAsync(
            new GbP11DItemsCreateDeclarationsRequest
            {
                EmployeeId = "employeeId",
                TaxYear = 1000000,
                Item = new GbP11DItemsCreateDeclarationsRequestItem(
                    new GbP11DItemsCreateDeclarationsRequestItem.AssetTransferred(
                        new GbP11DItemsCreateDeclarationsRequestItemAssetTransferred
                        {
                            Asset =
                                GbP11DItemsCreateDeclarationsRequestItemAssetTransferredAsset.Cars,
                            Cost = "121.00",
                            MadeGood = "121.00",
                        }
                    )
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
