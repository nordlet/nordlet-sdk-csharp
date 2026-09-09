using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogItemsKindsUpdateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("saftType")]
    public PostV1CatalogItemsKindsUpdateRequestSaftType? SaftType { get; set; }

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
