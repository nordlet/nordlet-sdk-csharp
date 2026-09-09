using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Public;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetV1PublicPayTokenTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest_1()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/public/pay/token")
                    .UsingGet()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Public.GetV1PublicPayTokenAsync(
                new GetV1PublicPayTokenRequest { Token = "token" }
            )
        );
    }

    [NUnit.Framework.Test]
    public void MockServerTest_2()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/public/pay/token")
                    .UsingGet()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Public.GetV1PublicPayTokenAsync(
                new GetV1PublicPayTokenRequest { Token = "token" }
            )
        );
    }
}
