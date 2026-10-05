using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ConfigsListDeclarationsResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<ConfigsListDeclarationsResponseRowsItemFieldsItem> Fields { get; set; } =
        new List<ConfigsListDeclarationsResponseRowsItemFieldsItem>();

    [JsonPropertyName("endpoints")]
    public IEnumerable<ConfigsListDeclarationsResponseRowsItemEndpointsItem>? Endpoints { get; set; }

    [JsonPropertyName("values")]
    public Dictionary<string, string> Values { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("acceptsCertificate")]
    public required bool AcceptsCertificate { get; set; }

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
