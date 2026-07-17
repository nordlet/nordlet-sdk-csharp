using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Partners;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1PartnersContactsCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x",
              "partnerId": "x"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "partnerId": "x",
              "name": "name",
              "role": "role",
              "email": "email",
              "phone": "phone",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/contacts/create")
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

        var response = await Client.Partners.PostV1PartnersContactsCreateAsync(
            new PostV1PartnersContactsCreateRequest
            {
                Name = "x",
                Role = null,
                Email = null,
                Phone = null,
                Notes = null,
                PartnerId = "x",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "name": "name",
              "partnerId": "partnerId"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "partnerId": "partnerId",
              "name": "name",
              "role": "role",
              "email": "email",
              "phone": "phone",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/partners/contacts/create")
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

        var response = await Client.Partners.PostV1PartnersContactsCreateAsync(
            new PostV1PartnersContactsCreateRequest { Name = "name", PartnerId = "partnerId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
