using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Reference;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1ReferenceCnCodesUpsertTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "rows": [
                {
                  "code": "code",
                  "name": "x"
                },
                {
                  "code": "code",
                  "name": "x"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "upserted": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/cn-codes/upsert")
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

        var response = await Client.Reference.PostV1ReferenceCnCodesUpsertAsync(
            new PostV1ReferenceCnCodesUpsertRequest
            {
                Rows = new List<PostV1ReferenceCnCodesUpsertRequestRowsItem>()
                {
                    new PostV1ReferenceCnCodesUpsertRequestRowsItem
                    {
                        Code = "code",
                        Name = "x",
                        NameLt = null,
                        SupplementaryUnit = null,
                    },
                    new PostV1ReferenceCnCodesUpsertRequestRowsItem
                    {
                        Code = "code",
                        Name = "x",
                        NameLt = null,
                        SupplementaryUnit = null,
                    },
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
              "rows": [
                {
                  "code": "code",
                  "name": "name"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "upserted": 1000000
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/reference/cn-codes/upsert")
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

        var response = await Client.Reference.PostV1ReferenceCnCodesUpsertAsync(
            new PostV1ReferenceCnCodesUpsertRequest
            {
                Rows = new List<PostV1ReferenceCnCodesUpsertRequestRowsItem>()
                {
                    new PostV1ReferenceCnCodesUpsertRequestRowsItem
                    {
                        Code = "code",
                        Name = "name",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
