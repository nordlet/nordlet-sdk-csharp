using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogItemsSuppliersListRequest
{
    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
