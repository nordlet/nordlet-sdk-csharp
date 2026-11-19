using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbVatObligationsListTest : BaseMockServerTest
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
              }
            }
            """;

        const string mockResponse = """
            {
              "obligations": [
                {
                  "periodKey": "periodKey",
                  "start": "start",
                  "end": "end",
                  "due": "due",
                  "status": "O",
                  "received": "received"
                },
                {
                  "periodKey": "periodKey",
                  "start": "start",
                  "end": "end",
                  "due": "due",
                  "status": "O",
                  "received": "received"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/obligations/list")
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

        var response = await Client.Declarations.GbVatObligationsListAsync(
            new GbVatObligationsListDeclarationsRequest
            {
                Device = new GbVatObligationsListDeclarationsRequestDevice
                {
                    UserAgent = "x",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatObligationsListDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatObligationsListDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                        new GbVatObligationsListDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatObligationsListDeclarationsRequestDeviceWindowSize
                    {
                        Width = 1000000,
                        Height = 1000000,
                    },
                    Timezone = "timezone",
                },
                From = null,
                To = null,
                Status = null,
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
              }
            }
            """;

        const string mockResponse = """
            {
              "obligations": [
                {
                  "periodKey": "periodKey",
                  "start": "start",
                  "end": "end",
                  "due": "due",
                  "status": "O",
                  "received": "received"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/obligations/list")
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

        var response = await Client.Declarations.GbVatObligationsListAsync(
            new GbVatObligationsListDeclarationsRequest
            {
                Device = new GbVatObligationsListDeclarationsRequestDevice
                {
                    UserAgent = "userAgent",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatObligationsListDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatObligationsListDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatObligationsListDeclarationsRequestDeviceWindowSize
                    {
                        Width = 1000000,
                        Height = 1000000,
                    },
                    Timezone = "timezone",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
