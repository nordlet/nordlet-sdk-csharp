using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Agreements;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InsurancePoliciesCreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "policyNumber": "x",
              "insuredObject": "x",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15"
            }
            """;

        const string mockResponse = """
            {
              "id": "x",
              "insurerPartnerId": "x",
              "policyNumber": "policyNumber",
              "insuredObject": "insuredObject",
              "fromDate": "2023-01-15",
              "toDate": "2023-01-15",
              "premium": "premium",
              "currency": "currency",
              "notes": "notes",
              "createdAt": "2024-01-15T09:30:00.000Z"
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

        var response = await Client.Agreements.InsurancePoliciesCreateAsync(
            new InsurancePoliciesCreateAgreementsRequest
            {
                InsurerPartnerId = null,
                PolicyNumber = "x",
                InsuredObject = "x",
                FromDate = new DateOnly(2023, 1, 15),
                ToDate = new DateOnly(2023, 1, 15),
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
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01"
            }
            """;

        const string mockResponse = """
            {
              "id": "id",
              "insurerPartnerId": "insurerPartnerId",
              "policyNumber": "policyNumber",
              "insuredObject": "insuredObject",
              "fromDate": "2026-07-01",
              "toDate": "2026-07-01",
              "premium": "premium",
              "currency": "currency",
              "notes": "notes",
              "createdAt": "2026-07-01T09:30:00.000Z"
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

        var response = await Client.Agreements.InsurancePoliciesCreateAsync(
            new InsurancePoliciesCreateAgreementsRequest
            {
                PolicyNumber = "policyNumber",
                InsuredObject = "insuredObject",
                FromDate = new DateOnly(2026, 7, 1),
                ToDate = new DateOnly(2026, 7, 1),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
