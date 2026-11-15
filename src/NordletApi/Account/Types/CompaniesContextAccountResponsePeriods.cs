using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CompaniesContextAccountResponsePeriods : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("open")]
    public IEnumerable<CompaniesContextAccountResponsePeriodsOpenItem> Open { get; set; } =
        new List<CompaniesContextAccountResponsePeriodsOpenItem>();

    [JsonPropertyName("locked")]
    public IEnumerable<CompaniesContextAccountResponsePeriodsLockedItem> Locked { get; set; } =
        new List<CompaniesContextAccountResponsePeriodsLockedItem>();

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
