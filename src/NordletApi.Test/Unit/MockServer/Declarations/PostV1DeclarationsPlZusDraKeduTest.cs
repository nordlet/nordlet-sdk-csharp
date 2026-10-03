using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1DeclarationsPlZusDraKeduTest : BaseMockServerTest
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
              "year": 1000000,
              "month": 1000000,
              "fileName": "fileName",
              "xml": "xml",
              "source": "source",
              "insured": [
                {
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "pesel": "pesel",
                  "kodTytulu": {
                    "p1": "p1",
                    "p2": "p2",
                    "p3": "p3"
                  },
                  "pensionBase": "pensionBase",
                  "healthBase": "healthBase"
                },
                {
                  "employeeId": "x",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "pesel": "pesel",
                  "kodTytulu": {
                    "p1": "p1",
                    "p2": "p2",
                    "p3": "p3"
                  },
                  "pensionBase": "pensionBase",
                  "healthBase": "healthBase"
                }
              ],
              "warnings": [
                "warnings",
                "warnings"
              ],
              "notes": [
                "notes",
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/zus-dra/kedu")
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

        var response = await Client.Declarations.PostV1DeclarationsPlZusDraKeduAsync(
            new PostV1DeclarationsPlZusDraKeduRequest { Year = 1000000, Month = 1000000 }
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
              "year": 1000000,
              "month": 1000000,
              "fileName": "fileName",
              "xml": "xml",
              "source": "source",
              "insured": [
                {
                  "employeeId": "employeeId",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "pesel": "pesel",
                  "kodTytulu": {
                    "p1": "p1",
                    "p2": "p2",
                    "p3": "p3"
                  },
                  "pensionBase": "pensionBase",
                  "healthBase": "healthBase"
                }
              ],
              "warnings": [
                "warnings"
              ],
              "notes": [
                "notes"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/pl/zus-dra/kedu")
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

        var response = await Client.Declarations.PostV1DeclarationsPlZusDraKeduAsync(
            new PostV1DeclarationsPlZusDraKeduRequest { Year = 1000000, Month = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
