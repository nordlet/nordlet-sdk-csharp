using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionOrdersCompleteRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("scrappedQuantity")]
    public string? ScrappedQuantity { get; set; }

    [JsonPropertyName("componentsAccountCode")]
    public string? ComponentsAccountCode { get; set; }

    [JsonPropertyName("finishedAccountCode")]
    public string? FinishedAccountCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
