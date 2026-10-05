using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AssetsDisposeAssetsRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("reason")]
    public required AssetsDisposeAssetsRequestReason Reason { get; set; }

    /// <summary>
    /// Sale price excluding VAT; 0 when scrapped or written off
    /// </summary>
    [JsonPropertyName("proceeds")]
    public string? Proceeds { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
