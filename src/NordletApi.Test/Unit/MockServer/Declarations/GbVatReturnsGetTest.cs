using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbVatReturnsGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "device": {
                "userAgent": "x",
                "deviceId": "deviceId",
                "screens": [
                  {
                    "width": 1000000,
                    "height": 1000000,
                    "scalingFactor": 1.1,
                    "colourDepth": 1000000
                  },
                  {
                    "width": 1000000,
                    "height": 1000000,
                    "scalingFactor": 1.1,
                    "colourDepth": 1000000
                  }
                ],
                "windowSize": {
                  "width": 1000000,
                  "height": 1000000
                },
                "timezone": "timezone"
              },
              "periodKey": "x"
            }
            """;

        const string mockResponse = """
            {
              "periodKey": "periodKey",
              "vatDueSales": 1.1,
              "vatDueAcquisitions": 1.1,
              "totalVatDue": 1.1,
              "vatReclaimedCurrPeriod": 1.1,
              "netVatDue": 1.1,
              "totalValueSalesExVAT": 1.1,
              "totalValuePurchasesExVAT": 1.1,
              "totalValueGoodsSuppliedExVAT": 1.1,
              "totalAcquisitionsExVAT": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/returns/get")
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

        var response = await Client.Declarations.GbVatReturnsGetAsync(
            new GbVatReturnsGetDeclarationsRequest
            {
                Device = new GbVatReturnsGetDeclarationsRequestDevice
                {
                    UserAgent = "x",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatReturnsGetDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatReturnsGetDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                        new GbVatReturnsGetDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatReturnsGetDeclarationsRequestDeviceWindowSize
                    {
                        Width = 1000000,
                        Height = 1000000,
                    },
                    Timezone = "timezone",
                },
                PeriodKey = "x",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "device": {
                "userAgent": "userAgent",
                "deviceId": "deviceId",
                "screens": [
                  {
                    "width": 1000000,
                    "height": 1000000,
                    "scalingFactor": 1.1,
                    "colourDepth": 1000000
                  }
                ],
                "windowSize": {
                  "width": 1000000,
                  "height": 1000000
                },
                "timezone": "timezone"
              },
              "periodKey": "periodKey"
            }
            """;

        const string mockResponse = """
            {
              "periodKey": "periodKey",
              "vatDueSales": 1.1,
              "vatDueAcquisitions": 1.1,
              "totalVatDue": 1.1,
              "vatReclaimedCurrPeriod": 1.1,
              "netVatDue": 1.1,
              "totalValueSalesExVAT": 1.1,
              "totalValuePurchasesExVAT": 1.1,
              "totalValueGoodsSuppliedExVAT": 1.1,
              "totalAcquisitionsExVAT": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/returns/get")
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

        var response = await Client.Declarations.GbVatReturnsGetAsync(
            new GbVatReturnsGetDeclarationsRequest
            {
                Device = new GbVatReturnsGetDeclarationsRequestDevice
                {
                    UserAgent = "userAgent",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatReturnsGetDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatReturnsGetDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatReturnsGetDeclarationsRequestDeviceWindowSize
                    {
                        Width = 1000000,
                        Height = 1000000,
                    },
                    Timezone = "timezone",
                },
                PeriodKey = "periodKey",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
