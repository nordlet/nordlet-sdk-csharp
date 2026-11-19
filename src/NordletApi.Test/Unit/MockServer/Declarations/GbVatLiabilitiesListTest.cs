using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbVatLiabilitiesListTest : BaseMockServerTest
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
              "from": "2023-01-15",
              "to": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "liabilities": [
                {
                  "taxPeriod": {
                    "from": "from",
                    "to": "to"
                  },
                  "type": "type",
                  "originalAmount": 1.1,
                  "outstandingAmount": 1.1,
                  "due": "due"
                },
                {
                  "taxPeriod": {
                    "from": "from",
                    "to": "to"
                  },
                  "type": "type",
                  "originalAmount": 1.1,
                  "outstandingAmount": 1.1,
                  "due": "due"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/liabilities/list")
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

        var response = await Client.Declarations.GbVatLiabilitiesListAsync(
            new GbVatLiabilitiesListDeclarationsRequest
            {
                Device = new GbVatLiabilitiesListDeclarationsRequestDevice
                {
                    UserAgent = "x",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatLiabilitiesListDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatLiabilitiesListDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                        new GbVatLiabilitiesListDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatLiabilitiesListDeclarationsRequestDeviceWindowSize
                    {
                        Width = 1000000,
                        Height = 1000000,
                    },
                    Timezone = "timezone",
                },
                From = new DateOnly(2023, 1, 15),
                To = new DateOnly(2023, 1, 15),
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
              "from": "2026-07-01",
              "to": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "liabilities": [
                {
                  "taxPeriod": {
                    "from": "from",
                    "to": "to"
                  },
                  "type": "type",
                  "originalAmount": 1.1,
                  "outstandingAmount": 1.1,
                  "due": "due"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/liabilities/list")
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

        var response = await Client.Declarations.GbVatLiabilitiesListAsync(
            new GbVatLiabilitiesListDeclarationsRequest
            {
                Device = new GbVatLiabilitiesListDeclarationsRequestDevice
                {
                    UserAgent = "userAgent",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatLiabilitiesListDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatLiabilitiesListDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatLiabilitiesListDeclarationsRequestDeviceWindowSize
                    {
                        Width = 1000000,
                        Height = 1000000,
                    },
                    Timezone = "timezone",
                },
                From = new DateOnly(2026, 7, 1),
                To = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
