using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Payroll;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PayrollCalcTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "taxableBase": "taxableBase",
              "date": "date"
            }
            """;

        const string mockResponse = """
            {
              "npd": "npd",
              "gpm": "gpm",
              "sodraEmployee": "sodraEmployee",
              "sodraEmployer": "sodraEmployer",
              "net": "net"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/calc")
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

        var response = await Client.Payroll.PostV1PayrollCalcAsync(
            new PostV1PayrollCalcRequest
            {
                TaxableBase = "taxableBase",
                Date = "date",
                ApplyNpd = null,
                NpdOverride = null,
                PensionAccumulation = null,
                FixedTerm = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "taxableBase": "taxableBase",
              "date": "date"
            }
            """;

        const string mockResponse = """
            {
              "npd": "npd",
              "gpm": "gpm",
              "sodraEmployee": "sodraEmployee",
              "sodraEmployer": "sodraEmployer",
              "net": "net"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/payroll/calc")
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

        var response = await Client.Payroll.PostV1PayrollCalcAsync(
            new PostV1PayrollCalcRequest { TaxableBase = "taxableBase", Date = "date" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
