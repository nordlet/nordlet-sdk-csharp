using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogItemsKindsCreateRequest
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("saftType")]
    public PostV1CatalogItemsKindsCreateRequestSaftType? SaftType { get; set; }

    [JsonPropertyName("quantityAccounting")]
    public bool? QuantityAccounting { get; set; }

    [JsonPropertyName("sortOrder")]
    public long? SortOrder { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
