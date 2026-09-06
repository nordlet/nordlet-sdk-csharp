using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerAccountsUpdateRequestTranslations : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("lt")]
    public PostV1LedgerAccountsUpdateRequestTranslationsLt? Lt { get; set; }

    [JsonPropertyName("en")]
    public PostV1LedgerAccountsUpdateRequestTranslationsEn? En { get; set; }

    [JsonPropertyName("ru")]
    public PostV1LedgerAccountsUpdateRequestTranslationsRu? Ru { get; set; }

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
