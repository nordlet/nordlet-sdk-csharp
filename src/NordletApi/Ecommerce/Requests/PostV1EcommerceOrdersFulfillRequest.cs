using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1EcommerceOrdersFulfillRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("cogsAccountCode")]
    public string? CogsAccountCode { get; set; }

    [JsonPropertyName("inventoryAccountCode")]
    public string? InventoryAccountCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
