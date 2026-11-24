using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItInailAutoliquidazioneF24DeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("positions")]
    public IEnumerable<ItInailAutoliquidazioneF24DeclarationsRequestPositionsItem> Positions { get; set; } =
        new List<ItInailAutoliquidazioneF24DeclarationsRequestPositionsItem>();

    [JsonPropertyName("rataAnticipata")]
    public string? RataAnticipata { get; set; }

    [JsonPropertyName("rateazione")]
    public bool? Rateazione { get; set; }

    [JsonPropertyName("codiceDitta")]
    public string? CodiceDitta { get; set; }

    [JsonPropertyName("codiceDittaControlCode")]
    public string? CodiceDittaControlCode { get; set; }

    [JsonPropertyName("sedeInail")]
    public string? SedeInail { get; set; }

    [JsonPropertyName("instalment")]
    public long? Instalment { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
