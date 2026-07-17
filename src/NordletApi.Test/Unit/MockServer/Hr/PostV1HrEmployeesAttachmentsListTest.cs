using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrEmployeesAttachmentsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "x",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "createdAt": "createdAt"
                },
                {
                  "id": "x",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/attachments/list")
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

        var response = await Client.Hr.PostV1HrEmployeesAttachmentsListAsync(
            new PostV1HrEmployeesAttachmentsListRequest { EmployeeId = "x" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "employeeId": "employeeId"
            }
            """;

        const string mockResponse = """
            {
              "rows": [
                {
                  "id": "id",
                  "fileName": "fileName",
                  "mimeType": "mimeType",
                  "sizeBytes": 1000000,
                  "createdAt": "createdAt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/attachments/list")
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

        var response = await Client.Hr.PostV1HrEmployeesAttachmentsListAsync(
            new PostV1HrEmployeesAttachmentsListRequest { EmployeeId = "employeeId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
