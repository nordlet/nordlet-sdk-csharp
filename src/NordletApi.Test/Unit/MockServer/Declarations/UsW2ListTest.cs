using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsW2ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "forms": [
                {
                  "employeeId": "employeeId",
                  "boxA": "boxA",
                  "boxE": {
                    "firstName": "firstName",
                    "lastName": "lastName"
                  },
                  "box1": "box1",
                  "box2": "box2",
                  "box3": "box3",
                  "box4": "box4",
                  "box5": "box5",
                  "box6": "box6",
                  "states": [
                    {
                      "box15": {
                        "state": "state",
                        "employerStateId": "employerStateId"
                      },
                      "box16": "box16",
                      "box17": "box17"
                    },
                    {
                      "box15": {
                        "state": "state",
                        "employerStateId": "employerStateId"
                      },
                      "box16": "box16",
                      "box17": "box17"
                    }
                  ]
                },
                {
                  "employeeId": "employeeId",
                  "boxA": "boxA",
                  "boxE": {
                    "firstName": "firstName",
                    "lastName": "lastName"
                  },
                  "box1": "box1",
                  "box2": "box2",
                  "box3": "box3",
                  "box4": "box4",
                  "box5": "box5",
                  "box6": "box6",
                  "states": [
                    {
                      "box15": {
                        "state": "state",
                        "employerStateId": "employerStateId"
                      },
                      "box16": "box16",
                      "box17": "box17"
                    },
                    {
                      "box15": {
                        "state": "state",
                        "employerStateId": "employerStateId"
                      },
                      "box16": "box16",
                      "box17": "box17"
                    }
                  ]
                }
              ],
              "w3": {
                "boxC": 1.1,
                "boxE": "boxE",
                "boxF": "boxF",
                "box1": "box1",
                "box2": "box2",
                "box3": "box3",
                "box4": "box4",
                "box5": "box5",
                "box6": "box6",
                "box16": "box16",
                "box17": "box17"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/w2/list")
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

        var response = await Client.Declarations.UsW2ListAsync(
            new UsW2ListDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "forms": [
                {
                  "employeeId": "employeeId",
                  "boxA": "boxA",
                  "boxE": {
                    "firstName": "firstName",
                    "lastName": "lastName"
                  },
                  "box1": "box1",
                  "box2": "box2",
                  "box3": "box3",
                  "box4": "box4",
                  "box5": "box5",
                  "box6": "box6",
                  "states": [
                    {
                      "box15": {
                        "state": "state"
                      },
                      "box16": "box16",
                      "box17": "box17"
                    }
                  ]
                }
              ],
              "w3": {
                "boxC": 1.1,
                "boxE": "boxE",
                "boxF": "boxF",
                "box1": "box1",
                "box2": "box2",
                "box3": "box3",
                "box4": "box4",
                "box5": "box5",
                "box6": "box6",
                "box16": "box16",
                "box17": "box17"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/w2/list")
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

        var response = await Client.Declarations.UsW2ListAsync(
            new UsW2ListDeclarationsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
