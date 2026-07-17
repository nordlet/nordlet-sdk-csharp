using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionBomsCreateRequest
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("finishedItemId")]
    public required string FinishedItemId { get; set; }

    [JsonPropertyName("outputQuantity")]
    public string? OutputQuantity { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1ProductionBomsCreateRequestLinesItem> Lines { get; set; } =
        new List<PostV1ProductionBomsCreateRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
