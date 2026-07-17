using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrEmployeesRecordsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "employeeId": "x",
              "type": "education",
              "title": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "employeeId": "x",
              "type": "education",
              "title": "title",
              "institution": "institution",
              "issuedAt": "issuedAt",
              "validUntil": "validUntil",
              "fileId": "x",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/records/create")
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

        var response = await Client.Hr.PostV1HrEmployeesRecordsCreateAsync(
            new PostV1HrEmployeesRecordsCreateRequest
            {
                EmployeeId = "x",
                Type = PostV1HrEmployeesRecordsCreateRequestType.Education,
                Title = "x",
                Institution = null,
                IssuedAt = null,
                ValidUntil = null,
                FileId = null,
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
              "type": "education",
              "title": "title"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "employeeId": "employeeId",
              "type": "education",
              "title": "title",
              "institution": "institution",
              "issuedAt": "issuedAt",
              "validUntil": "validUntil",
              "fileId": "fileId",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/records/create")
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

        var response = await Client.Hr.PostV1HrEmployeesRecordsCreateAsync(
            new PostV1HrEmployeesRecordsCreateRequest
            {
                EmployeeId = "employeeId",
                Type = PostV1HrEmployeesRecordsCreateRequestType.Education,
                Title = "title",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
