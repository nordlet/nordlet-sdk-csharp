using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsDeUnemploymentGetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "quarter": 1.1,
              "totalWages": "totalWages",
              "excessWages": "excessWages",
              "taxableWages": "taxableWages",
              "contributions": "contributions",
              "employees": [
                {
                  "employeeId": "employeeId",
                  "socialSecurityNumber": "socialSecurityNumber",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "wages": "wages"
                },
                {
                  "employeeId": "employeeId",
                  "socialSecurityNumber": "socialSecurityNumber",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "wages": "wages"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/unemployment/get")
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

        var response = await Client.Declarations.UsDeUnemploymentGetAsync(
            new UsDeUnemploymentGetDeclarationsRequest { Year = 1000000, Quarter = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "quarter": 1000000
            }
            """;

        const string mockResponse = """
            {
              "year": 1.1,
              "quarter": 1.1,
              "totalWages": "totalWages",
              "excessWages": "excessWages",
              "taxableWages": "taxableWages",
              "contributions": "contributions",
              "employees": [
                {
                  "employeeId": "employeeId",
                  "socialSecurityNumber": "socialSecurityNumber",
                  "firstName": "firstName",
                  "lastName": "lastName",
                  "wages": "wages"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/us/de/unemployment/get")
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

        var response = await Client.Declarations.UsDeUnemploymentGetAsync(
            new UsDeUnemploymentGetDeclarationsRequest { Year = 1000000, Quarter = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
