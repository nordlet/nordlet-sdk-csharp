using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrIncapacityCertificatesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "number": "x",
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "employeeId": "x",
              "series": "series",
              "number": "number",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "reason": "reason",
              "notes": "notes"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/incapacity-certificates/create")
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

        var response = await Client.Hr.PostV1HrIncapacityCertificatesCreateAsync(
            new PostV1HrIncapacityCertificatesCreateRequest
            {
                EmployeeId = "x",
                Series = null,
                Number = "x",
                FromDate = "fromDate",
                ToDate = "toDate",
                Reason = null,
                Notes = null,
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
              "number": "number",
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "series": "series",
              "number": "number",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "reason": "reason",
              "notes": "notes"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/incapacity-certificates/create")
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

        var response = await Client.Hr.PostV1HrIncapacityCertificatesCreateAsync(
            new PostV1HrIncapacityCertificatesCreateRequest
            {
                EmployeeId = "employeeId",
                Number = "number",
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
