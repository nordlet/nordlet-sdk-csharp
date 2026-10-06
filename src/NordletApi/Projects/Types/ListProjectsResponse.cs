using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ListProjectsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rows")]
    public IEnumerable<ListProjectsResponseRowsItem> Rows { get; set; } =
        new List<ListProjectsResponseRowsItem>();

    [JsonPropertyName("page")]
    public required long Page { get; set; }

    [JsonPropertyName("pageSize")]
    public required long PageSize { get; set; }

    [JsonPropertyName("total")]
    public required long Total { get; set; }

    [JsonPropertyName("totals")]
    public Dictionary<string, string>? Totals { get; set; }

    /// <summary>
    /// The requested totals split by currency code, present when the listed records carry a currency
    /// </summary>
    [JsonPropertyName("totalsByCurrency")]
    public Dictionary<string, Dictionary<string, string>>? TotalsByCurrency { get; set; }

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
