using NordletApi;
using NordletApi.Test.Unit.MockServer;
using NordletApi.Test.Utils;
using NUnit.Framework;

namespace NordletApi.Test.Unit.MockServer.Declarations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ItInailAutoliquidazioneF24Test : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "positions": [
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "tassoRegolazione": "tassoRegolazione",
                  "tassoRata": "tassoRata"
                },
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "tassoRegolazione": "tassoRegolazione",
                  "tassoRata": "tassoRata"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "contentType": "contentType",
              "data": "data",
              "total": "total",
              "warnings": [
                "warnings",
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/it/inail/autoliquidazione/f24")
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

        var response = await Client.Declarations.ItInailAutoliquidazioneF24Async(
            new ItInailAutoliquidazioneF24DeclarationsRequest
            {
                Year = 1000000,
                Positions = new List<ItInailAutoliquidazioneF24DeclarationsRequestPositionsItem>()
                {
                    new ItInailAutoliquidazioneF24DeclarationsRequestPositionsItem
                    {
                        Pat = "pat",
                        PatControlCode = "patControlCode",
                        Voce = "voce",
                        TassoRegolazione = "tassoRegolazione",
                        TassoRata = "tassoRata",
                        RiduzioneRegolazione = null,
                        RiduzioneRata = null,
                        QuoteEsenti = null,
                        RetribuzioniRata = null,
                        EmployeeIds = null,
                    },
                    new ItInailAutoliquidazioneF24DeclarationsRequestPositionsItem
                    {
                        Pat = "pat",
                        PatControlCode = "patControlCode",
                        Voce = "voce",
                        TassoRegolazione = "tassoRegolazione",
                        TassoRata = "tassoRata",
                        RiduzioneRegolazione = null,
                        RiduzioneRata = null,
                        QuoteEsenti = null,
                        RetribuzioniRata = null,
                        EmployeeIds = null,
                    },
                },
                RataAnticipata = null,
                Rateazione = null,
                CodiceDitta = null,
                CodiceDittaControlCode = null,
                SedeInail = null,
                Instalment = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "year": 1000000,
              "positions": [
                {
                  "pat": "pat",
                  "patControlCode": "patControlCode",
                  "voce": "voce",
                  "tassoRegolazione": "121.00000",
                  "tassoRata": "121.00000"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "fileName": "fileName",
              "contentType": "contentType",
              "data": "data",
              "total": "total",
              "warnings": [
                "warnings"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/declarations/it/inail/autoliquidazione/f24")
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

        var response = await Client.Declarations.ItInailAutoliquidazioneF24Async(
            new ItInailAutoliquidazioneF24DeclarationsRequest
            {
                Year = 1000000,
                Positions = new List<ItInailAutoliquidazioneF24DeclarationsRequestPositionsItem>()
                {
                    new ItInailAutoliquidazioneF24DeclarationsRequestPositionsItem
                    {
                        Pat = "pat",
                        PatControlCode = "patControlCode",
                        Voce = "voce",
                        TassoRegolazione = "121.00000",
                        TassoRata = "121.00000",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
