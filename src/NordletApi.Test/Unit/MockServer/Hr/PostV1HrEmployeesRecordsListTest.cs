using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Hr;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1HrEmployeesRecordsListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
                },
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/records/list")
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

        var response = await Client.Hr.PostV1HrEmployeesRecordsListAsync(
            new PostV1HrEmployeesRecordsListRequest
            {
                Page = null,
                PageSize = null,
                Sort = null,
                Filter = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "rows": [
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
              ],
              "page": 1000000,
              "pageSize": 1000000,
              "total": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/hr/employees/records/list")
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

        var response = await Client.Hr.PostV1HrEmployeesRecordsListAsync(
            new PostV1HrEmployeesRecordsListRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
