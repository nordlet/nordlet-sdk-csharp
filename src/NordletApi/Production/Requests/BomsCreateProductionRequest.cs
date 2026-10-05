using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BomsCreateProductionRequest
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("finishedItemId")]
    public required string FinishedItemId { get; set; }

    [JsonPropertyName("outputQuantity")]
    public string? OutputQuantity { get; set; }

    [JsonPropertyName("routingId")]
    public string? RoutingId { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<BomsCreateProductionRequestLinesItem> Lines { get; set; } =
        new List<BomsCreateProductionRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
