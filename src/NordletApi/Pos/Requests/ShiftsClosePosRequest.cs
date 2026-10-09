using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ShiftsClosePosRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("countedCash")]
    public required string CountedCash { get; set; }

    [JsonPropertyName("date")]
    public DateOnly? Date { get; set; }

    [JsonPropertyName("reportNumber")]
    public string? ReportNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
