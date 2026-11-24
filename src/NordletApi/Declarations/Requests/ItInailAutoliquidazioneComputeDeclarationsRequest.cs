using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItInailAutoliquidazioneComputeDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("positions")]
    public IEnumerable<ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem> Positions { get; set; } =
        new List<ItInailAutoliquidazioneComputeDeclarationsRequestPositionsItem>();

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
