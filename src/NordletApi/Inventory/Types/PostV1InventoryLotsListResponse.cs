using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1InventoryLotsListResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1InventoryLotsListResponseRowsItem> Rows { get; set; } =
        new List<PostV1InventoryLotsListResponseRowsItem>();

    [JsonPropertyName("page")]
    public required long Page { get; set; }

    [JsonPropertyName("pageSize")]
    public required long PageSize { get; set; }

    [JsonPropertyName("total")]
    public required long Total { get; set; }

    [JsonPropertyName("totals")]
    public Dictionary<string, string>? Totals { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
