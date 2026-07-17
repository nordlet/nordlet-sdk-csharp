using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class PostV1AgreementsInsurancePoliciesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "policyNumber": "x",
              "insuredObject": "x",
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "insurerPartnerId": "x",
              "policyNumber": "policyNumber",
              "insuredObject": "insuredObject",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "premium": "premium",
              "currency": "currency",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/insurance-policies/create")
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

        var response = await Client.Agreements.PostV1AgreementsInsurancePoliciesCreateAsync(
            new PostV1AgreementsInsurancePoliciesCreateRequest
            {
                InsurerPartnerId = null,
                PolicyNumber = "x",
                InsuredObject = "x",
                FromDate = "fromDate",
                ToDate = "toDate",
                Premium = null,
                Currency = null,
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
              "policyNumber": "policyNumber",
              "insuredObject": "insuredObject",
              "fromDate": "fromDate",
              "toDate": "toDate"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "insurerPartnerId": "insurerPartnerId",
              "policyNumber": "policyNumber",
              "insuredObject": "insuredObject",
              "fromDate": "fromDate",
              "toDate": "toDate",
              "premium": "premium",
              "currency": "currency",
              "notes": "notes",
              "createdAt": "createdAt"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/agreements/insurance-policies/create")
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

        var response = await Client.Agreements.PostV1AgreementsInsurancePoliciesCreateAsync(
            new PostV1AgreementsInsurancePoliciesCreateRequest
            {
                PolicyNumber = "policyNumber",
                InsuredObject = "insuredObject",
                FromDate = "fromDate",
                ToDate = "toDate",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
