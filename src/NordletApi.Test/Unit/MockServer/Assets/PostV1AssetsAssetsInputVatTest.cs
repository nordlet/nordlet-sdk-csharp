using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Assets;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AssetsAssetsInputVatTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "id": "x",
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
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "groupId": "x",
              "code": "code",
              "name": "name",
              "acquisitionDate": "acquisitionDate",
              "depreciationStartDate": "depreciationStartDate",
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
              "inputVatFirstUseDate": "inputVatFirstUseDate",
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
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/input-vat")
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

        var response = await Client.Assets.PostV1AssetsAssetsInputVatAsync(
            new PostV1AssetsAssetsInputVatRequest
            {
                Id = "x",
                InputVatAmount = null,
                InputVatFirstUseDate = null,
                InputVatDeductiblePercent = null,
                InputVatRealEstate = true,
                InputVatUseChanges =
                    new List<PostV1AssetsAssetsInputVatRequestInputVatUseChangesItem>()
                    {
                        new PostV1AssetsAssetsInputVatRequestInputVatUseChangesItem
                        {
                            Year = 1000000,
                            Percent = "percent",
                            Reason =
                                PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason.UseChange,
                        },
                        new PostV1AssetsAssetsInputVatRequestInputVatUseChangesItem
                        {
                            Year = 1000000,
                            Percent = "percent",
                            Reason =
                                PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason.UseChange,
                        },
                    },
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
              "inputVatRealEstate": true,
              "inputVatUseChanges": [
                {
                  "year": 1000000,
                  "percent": "percent",
                  "reason": "use_change"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "groupId": "groupId",
              "code": "code",
              "name": "name",
              "acquisitionDate": "acquisitionDate",
              "depreciationStartDate": "depreciationStartDate",
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
              "inputVatFirstUseDate": "inputVatFirstUseDate",
              "inputVatDeductiblePercent": "inputVatDeductiblePercent",
              "inputVatRealEstate": true,
              "inputVatUseChanges": [
                {
                  "year": 1000000,
                  "percent": "percent",
                  "reason": "use_change"
                }
              ],
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/assets/assets/input-vat")
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

        var response = await Client.Assets.PostV1AssetsAssetsInputVatAsync(
            new PostV1AssetsAssetsInputVatRequest
            {
                Id = "id",
                InputVatRealEstate = true,
                InputVatUseChanges =
                    new List<PostV1AssetsAssetsInputVatRequestInputVatUseChangesItem>()
                    {
                        new PostV1AssetsAssetsInputVatRequestInputVatUseChangesItem
                        {
                            Year = 1000000,
                            Percent = "percent",
                            Reason =
                                PostV1AssetsAssetsInputVatRequestInputVatUseChangesItemReason.UseChange,
                        },
                    },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
