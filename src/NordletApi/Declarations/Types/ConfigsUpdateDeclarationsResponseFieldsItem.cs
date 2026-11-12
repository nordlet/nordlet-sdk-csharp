using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ConfigsUpdateDeclarationsResponseFieldsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("kind")]
    public required ConfigsUpdateDeclarationsResponseFieldsItemKind Kind { get; set; }

    [JsonPropertyName("multiline")]
    public bool? Multiline { get; set; }

    /// <summary>
    /// The allowed values of a `select` field
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<string>? Options { get; set; }

    /// <summary>
    /// The company profile field the value is taken from; change it with `account/companies/update`
    /// </summary>
    [JsonPropertyName("companyField")]
    public ConfigsUpdateDeclarationsResponseFieldsItemCompanyField? CompanyField { get; set; }

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
