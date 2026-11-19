using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GbVatPenaltiesGetTest : BaseMockServerTest
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
              "string": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/penalties/get")
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

        var response = await Client.Declarations.GbVatPenaltiesGetAsync(
            new GbVatPenaltiesGetDeclarationsRequest
            {
                Device = new GbVatPenaltiesGetDeclarationsRequestDevice
                {
                    UserAgent = "x",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatPenaltiesGetDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatPenaltiesGetDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                        new GbVatPenaltiesGetDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatPenaltiesGetDeclarationsRequestDeviceWindowSize
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
              "key": "value"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/gb/vat/penalties/get")
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

        var response = await Client.Declarations.GbVatPenaltiesGetAsync(
            new GbVatPenaltiesGetDeclarationsRequest
            {
                Device = new GbVatPenaltiesGetDeclarationsRequestDevice
                {
                    UserAgent = "userAgent",
                    DeviceId = "deviceId",
                    Screens = new List<GbVatPenaltiesGetDeclarationsRequestDeviceScreensItem>()
                    {
                        new GbVatPenaltiesGetDeclarationsRequestDeviceScreensItem
                        {
                            Width = 1000000,
                            Height = 1000000,
                            ScalingFactor = 1.1,
                            ColourDepth = 1000000,
                        },
                    },
                    WindowSize = new GbVatPenaltiesGetDeclarationsRequestDeviceWindowSize
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
